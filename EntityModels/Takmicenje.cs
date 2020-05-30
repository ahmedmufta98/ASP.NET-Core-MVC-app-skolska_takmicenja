using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class Takmicenje
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public int Razred { get; set; }
        public int SkolaId { get; set; }
        public Skola Skola { get; set; }
        public bool Zakljucan { get; set; }
    }
}
