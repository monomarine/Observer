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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Скорость превышена! Патрульный выезжает на нарушение");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Скорость в пределах нормы");
                Console.ResetColor();
            }
        }
    }
}
