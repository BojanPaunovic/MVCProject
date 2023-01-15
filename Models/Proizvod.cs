using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjekatPSA.Models
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public string NacinPlacanja { get; set; }
        public double Cena { get; set; }
        public double Popust { get; set; }
        public string Opis { get; set; }
    }
}