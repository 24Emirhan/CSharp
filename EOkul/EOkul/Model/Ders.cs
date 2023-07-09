using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul.Model
{
    public class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Numarasi { get; set; }
        public double MatOrt { get; set; }
        public double FizikOrt { get; set; }
        public double BiyolojiOrt { get; set; }
        public double KimyaOrt { get; set; }
        public double TurkceOrt { get; set; }
    }
}
