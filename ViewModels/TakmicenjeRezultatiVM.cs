using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjeRezultatiVM
    {
        public int SkolaId { get; set; }
        public string Skola { get; set; }
        public string Predmet { get; set; }
        public int Razred { get; set; }
        public string Datum { get; set; }
        public int TakmicenjeId { get; set; }
        public bool Zakljucan { get; set; }
    }
}
