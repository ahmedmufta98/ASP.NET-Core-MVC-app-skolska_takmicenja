using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjeUrediDodajUcesnikaVM
    {
        public int Id { get; set; }
        public int TakmicenjeId { get; set; }
        public string Ucenik { get; set; }
        public int OdjeljenjeStavkaId { get; set; }
        public List<SelectListItem> OdjeljenjeStavke { get; set; }
        public int? Bodovi { get; set; }
    }
}
