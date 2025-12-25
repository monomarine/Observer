using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PatrolOfficer : IObserver
    {
        private int overSpeedCounter = 0;

        public void Update(float speed)
        {
            if (speed > 150)
            {
                overSpeedCounter++;
                Console.WriteLine($"Превышение скорости! ({overSpeedCounter}/10)");
            }
            else
            {
                overSpeedCounter = 0;
                Console.WriteLine("Скорость в пределах нормы.");
            }

            if (overSpeedCounter >= 10)
            {
                Console.WriteLine("Длительное превышение скорости! Патруль оформляет нарушение!");
                overSpeedCounter = 0; 
            }
        }
    }
}
