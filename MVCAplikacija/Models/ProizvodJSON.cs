using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAplikacija.Models
{
    public class ProizvodJSON
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Kategorija { get; set; }
        public string Proizvodjac { get; set; }
        public string Dobavljac { get; set; }
        public string Cena { get; set; }
    }
}