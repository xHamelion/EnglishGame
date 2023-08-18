using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGame
{
    public class Zadan
    {
        public int Tip { get; set; }
        public string Vopros { get; set; }
        public string Otvet { get; set; }
        public Zadan(int t, string v, string o)
        {
            this.Tip = t;
            this.Vopros = v;
            this.Otvet = o;

        }
    }
}
