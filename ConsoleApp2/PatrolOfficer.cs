using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PatrolOfficer : IObserver
    {
        public void Update(float speed)
        {
            if (speed > 100)
            {
                Console.WriteLine($"Скорость превышена - {speed} км/ч ! Патрульный выезжает на нарушение.");
            }
            else if (speed > 150)
            {
                Console.WriteLine($"Предельное привышение скорости, {speed} км/ч превышена! Патрульный выезжает на нарушение.");
            }
            else
            {
                Console.WriteLine($"Скорость {speed} км/ч в пределах нормы.");
            }
        }
    }
}
