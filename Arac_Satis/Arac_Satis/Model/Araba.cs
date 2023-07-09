using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_Satis.Model
{
    public class Araba
    {
        public int Id { get; set; }
        public int IlanNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Kilometre { get; set; }
        public double Fiyat { get; set; }
        public double Tramer { get; set; }
    }
}
