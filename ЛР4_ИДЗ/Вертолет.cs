using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    internal class Вертолет : ТехСредство
    {
        protected int Height;

        public Вертолет(string pName, int pPrice, int pheight) : base(pName, pPrice)
        {
            Height = pheight;
        }
    }
}
