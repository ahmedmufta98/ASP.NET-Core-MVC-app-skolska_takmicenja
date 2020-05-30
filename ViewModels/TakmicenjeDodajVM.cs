using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjeDodajVM
    {
        public string Skola { get; set; }
        public int SkolaId { get; set; }
        public int PredmetId { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public DateTime Datum { get; set; }
        public int Razred { get; set; }
        public List<SelectListItem> Razredi { get; set; }
    }
}
