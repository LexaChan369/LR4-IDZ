using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    internal class ЛегковойАвтомобиль : Автомобиль
    {
        protected int weight;
        public ЛегковойАвтомобиль(string pName, int pPrice, int pSpeed, int pWeight) : base(pName, pPrice, pSpeed)
        {
            this.weight = pWeight;
        }
    }
}
