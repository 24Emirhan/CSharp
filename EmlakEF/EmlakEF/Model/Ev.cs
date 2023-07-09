using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakEF.Model
{
    public class Ev
    {
        public int Id { get; set; }
        public int IlanNo { get; set; }
        public int OdaSayisi { get; set; }
        public int KatNo { get; set; }
        public string Alan { get; set; }
        public string Semt { get; set; }
    }
}
