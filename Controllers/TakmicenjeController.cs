using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class TakmicenjeController : Controller
    {
        private MojContext _context;

        public TakmicenjeController(MojContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listaSkola = _context.Skola.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Naziv
            }).ToList();
            List<SelectListItem> razredi = new List<SelectListItem>();
            razredi.Insert(0, new SelectListItem { Value = null, Text = "--Odaberite razred--", Selected = true });
            for(var i = 1; i <= 4; i++)
            {
                razredi.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            TakmicenjeIndexVM model = new TakmicenjeIndexVM
            {
                Skole = listaSkola,
                Razredi = razredi
            };
            return View(model);
        }
        public IActionResult PrikazTakmicenja(int SkolaId,int? Razred)
        {
            var skola = _context.Skola.Find(SkolaId);
            TakmicenjePrikazTakmicenjaVM model = new TakmicenjePrikazTakmicenjaVM
            {
                SkolaId = skola.Id,
                Skola = skola.Naziv,
                Razred = Razred,
                Rows =_context.Takmicenje.Where(t=>t.SkolaId==SkolaId)
                                         .Where(t=>Razred.HasValue && Razred.Value==t.Razred)
                                         .Select(t=>new TakmicenjePrikazTakmicenjaVM.Row
                                         {
                                             Id=t.Id,
                                             Predmet=t.Predmet.Naziv,
                                             Razred=t.Razred,
                                             Datum=t.Datum,
                                             BrojUcesnikaKojiNisuPristupili=_context.TakmicenjeUcesnik.Where(tu=>tu.TakmicenjeId==t.Id && tu.Pristupio==false)
                                                                                                      .Count()                                        
                                         }).ToList()
            };
            foreach(var ucesnik in model.Rows)
            {
                var listaUcesnika = _context.TakmicenjeUcesnik.Where(tu=>tu.TakmicenjeId==ucesnik.Id)
                                                            .Include(tu => tu.Takmicenje)
                                                            .Include(tu => tu.OdjeljenjeStavka)
                                                            .ToList();
                string najboljaSkola = "", najboljeOdjeljenje = "", najboljiUcenik = "";
                var najboljiBodovi = 0;
                foreach(var u in listaUcesnika)
                {
                    if (u.Bodovi > najboljiBodovi)
                    {
                        najboljiBodovi = (int)u.Bodovi;
                        var takmicenje = _context.Takmicenje.Find(u.TakmicenjeId);
                        var odjeljenjeStavka = _context.OdjeljenjeStavka.Find(u.OdjeljenjeStavkaId);
                        var odjeljenje = _context.Odjeljenje.Find(odjeljenjeStavka.OdjeljenjeId);
                        var ucenik = _context.Ucenik.Find(odjeljenjeStavka.UcenikId);
                        var Skola = _context.Skola.Find(takmicenje.SkolaId);
                        najboljaSkola = Skola.Naziv;
                        najboljiUcenik = ucenik.ImePrezime;
                        najboljeOdjeljenje = odjeljenje.Oznaka;
                    }
                }
                ucesnik.NajboljiUcesnik = najboljaSkola + '|' + najboljeOdjeljenje + '|' + najboljiUcenik;
            }
            return View(model);
        }
        public IActionResult Dodaj(int SkolaId,int? Razred)
        {
            var skola = _context.Skola.Find(SkolaId);
            var listaPredemta = _context.Predmet.Where(p => Razred.HasValue && p.Razred == Razred.Value)
                                              .Select(p => new SelectListItem
                                              {
                                                  Value = p.Id.ToString(),
                                                  Text = p.Naziv
                                              }).ToList();
            List<SelectListItem> razredi = new List<SelectListItem>();
            for (var i = 1; i <= 4; i++)
            {
                razredi.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            TakmicenjeDodajVM model = new TakmicenjeDodajVM
            {
                Skola = skola.Naziv,
                SkolaId = skola.Id,
                Predmeti = listaPredemta,
                Razredi = razredi
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(TakmicenjeDodajVM model)
        {
            Takmicenje novoTakmicenje = new Takmicenje
            {
                SkolaId = model.SkolaId,
                PredmetId = model.PredmetId,
                Razred = model.Razred,
                Datum = model.Datum,
                Zakljucan = false
            };
            _context.Takmicenje.Add(novoTakmicenje);
            _context.SaveChanges();

            var listaPredmeta = _context.DodjeljenPredmet.Where(dp => dp.PredmetId == novoTakmicenje.PredmetId && dp.ZakljucnoKrajGodine == 5).ToList();
            foreach(var p in listaPredmeta)
            {
                if (_context.DodjeljenPredmet.Where(dp => dp.Id == p.Id).Average(dp => dp.ZakljucnoKrajGodine) >= 4)
                {
                    TakmicenjeUcesnik noviUcesnik = new TakmicenjeUcesnik
                    {
                        TakmicenjeId = novoTakmicenje.Id,
                        OdjeljenjeStavkaId = p.OdjeljenjeStavkaId,
                        Pristupio = true
                    };
                    _context.TakmicenjeUcesnik.Add(noviUcesnik);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction(nameof(PrikazTakmicenja), new { SkolaId = model.SkolaId, Razred = model.Razred });
        }
        public IActionResult Rezultati(int id)
        {
            var takmicenje = _context.Takmicenje.Find(id);
            var skola = _context.Skola.Find(takmicenje.SkolaId);
            var predmet = _context.Predmet.Find(takmicenje.PredmetId);
            TakmicenjeRezultatiVM model = new TakmicenjeRezultatiVM
            {
                TakmicenjeId = takmicenje.Id,
                SkolaId = skola.Id,
                Skola = skola.Naziv,
                Predmet = predmet.Naziv,
                Razred = takmicenje.Razred,
                Datum = takmicenje.Datum.ToString("dd.MM.yyyy"),
                Zakljucan=takmicenje.Zakljucan
            };
            return View(model);
        }
        public IActionResult Ucesnici(int id)
        {
            var takmicenje = _context.Takmicenje.Find(id);
            TakmicenjeUcesniciVM model = new TakmicenjeUcesniciVM
            {
                TakmicenjeId = id,
                Zakljucan = takmicenje.Zakljucan,
                Rows = _context.TakmicenjeUcesnik.Where(tu => tu.TakmicenjeId == id)
                                               .Select(tu => new TakmicenjeUcesniciVM.Row
                                               {
                                                   Id = tu.Id,
                                                   Odjeljenje = tu.OdjeljenjeStavka.Odjeljenje.Oznaka,
                                                   BrojUDnevniku = tu.OdjeljenjeStavka.BrojUDnevniku,
                                                   Pristupio = tu.Pristupio,
                                                   Bodovi = tu.Bodovi
                                               }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult Zakljucaj(int id)
        {
            var takmicenje = _context.Takmicenje.Find(id);
            if(takmicenje.Zakljucan==false)
            {
                takmicenje.Zakljucan = true;
                _context.Takmicenje.Update(takmicenje);
                _context.SaveChanges();
            }
            return Redirect("/Takmicenje/Ucesnici?id=" + takmicenje.Id);
        }
        public IActionResult UcenikJePrisutan(int id)
        {
            var ucenik = _context.TakmicenjeUcesnik.Find(id);
            ucenik.Pristupio = false;
            _context.TakmicenjeUcesnik.Update(ucenik);
            _context.SaveChanges();
            return Redirect("/Takmicenje/Ucesnici?id=" + ucenik.TakmicenjeId);
        }
        public IActionResult UcenikJeOdsutan(int id)
        {
            var ucenik = _context.TakmicenjeUcesnik.Find(id);
            ucenik.Pristupio = true;
            _context.TakmicenjeUcesnik.Update(ucenik);
            _context.SaveChanges();
            return Redirect("/Takmicenje/Ucesnici?id=" + ucenik.TakmicenjeId);
        }
        public IActionResult UrediUcesnika(int id)
        {
            var ucesnik = _context.TakmicenjeUcesnik.Find(id);
            var odjeljenjeStavka = _context.OdjeljenjeStavka.Find(ucesnik.OdjeljenjeStavkaId);
            var ucenik = _context.Ucenik.Find(odjeljenjeStavka.UcenikId);
            TakmicenjeUrediDodajUcesnikaVM model = new TakmicenjeUrediDodajUcesnikaVM
            {
                Id = ucesnik.Id,
                Ucenik = ucenik.ImePrezime,
                Bodovi = ucesnik.Bodovi
            };
            return PartialView(nameof(UrediDodajUcesnika),model);
        }
        public IActionResult DodajUcesnika(int id)
        {
            var takmicenje = _context.Takmicenje.Find(id);
            var listaUcenika = _context.OdjeljenjeStavka.Select(o => new SelectListItem
            {
                Value = o.Id.ToString(),
                Text = o.Ucenik.ImePrezime
            }).ToList();
            TakmicenjeUrediDodajUcesnikaVM model = new TakmicenjeUrediDodajUcesnikaVM
            {
                Id = 0,
                TakmicenjeId=takmicenje.Id,
                OdjeljenjeStavke=listaUcenika
            };
            return PartialView(nameof(UrediDodajUcesnika),model);
        }
        [HttpPost]
        public IActionResult UrediDodajUcesnika(TakmicenjeUrediDodajUcesnikaVM model)
        {
            if (model.Id == 0)
            {
                TakmicenjeUcesnik noviUcesnik = new TakmicenjeUcesnik
                {
                    TakmicenjeId = model.TakmicenjeId,
                    OdjeljenjeStavkaId = model.OdjeljenjeStavkaId,
                    Pristupio = true,
                    Bodovi = model.Bodovi
                };
                _context.TakmicenjeUcesnik.Add(noviUcesnik);
                _context.SaveChanges();
                return Redirect("/Takmicenje/Ucesnici?id=" + noviUcesnik.TakmicenjeId);
            }
            else
            {
                var ucesnik = _context.TakmicenjeUcesnik.Find(model.Id);
                ucesnik.Bodovi = model.Bodovi;
                _context.TakmicenjeUcesnik.Update(ucesnik);
                _context.SaveChanges();
                return Redirect("/Takmicenje/Ucesnici?id=" + ucesnik.TakmicenjeId);
            }
        }
    }
}