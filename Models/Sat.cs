using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjekatPSA.Models
{
    public class Sat : Proizvod
    {
        public string StilSata { get; set; }
        public string TipNarukvice { get; set; }
        public string TipPrikaza { get; set; }

    }
}