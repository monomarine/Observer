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
            if (speed > 150)
            {
                Console.WriteLine($"Скорость превышена - {speed}! Патрульный выезжает на нарушение.");
            }
            else
            {
                Console.WriteLine($"Скорость в пределах нормы - { speed}");
            }
        }
    }
}
