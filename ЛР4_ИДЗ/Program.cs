using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИДЗ4
{
    class Programm 
    {
        static void Main(string[] args)
        {
            var list = new List<ТехСредство>();
            list.Add(new ТехСредство("Квадрокоптер", 35000));
            list.Add(new Вертолет("Вертолет", 2494999, 2500));
            list.Add(new Автомобиль("Lada", 100000, 220)) ;
            list.Add(new ЛегковойАвтомобиль("BMW", 5000000, 300, 12000));
            list.Add(new ГрузовойАвтомобиль("Gazprom12", 94200000, 180, 10));
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
