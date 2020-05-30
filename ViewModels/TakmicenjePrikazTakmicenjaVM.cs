using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjePrikazTakmicenjaVM
    {
        public int SkolaId { get; set; }
        public int? Razred { get; set; }
        public string Skola { get; set; }
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int Id { get; set; }
            public string Predmet { get; set; }
            public int Razred { get; set; }
            public DateTime Datum { get; set; }
            public int BrojUcesnikaKojiNisuPristupili { get; set; }
            public string NajboljiUcesnik { get; set; }
        }
    }
}
