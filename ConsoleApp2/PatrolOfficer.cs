using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PatrolOfficer : IObserver
    {
        private int criticalOverspeedCounter = 0; 
        public void Update(float speed)
        {
            if (speed > 100 && speed <= 150)
            {
                Console.WriteLine($"[Патрульный] Скорость {speed} км/ч: Превышение! Выписывается штраф.");
                criticalOverspeedCounter = 0; 
            }
            else if (speed > 150)
            {
                criticalOverspeedCounter++;
                Console.WriteLine($"[Патрульный] Скорость {speed} км/ч: КРИТИЧЕСКОЕ ПРЕВЫШЕНИЕ! (итерация {criticalOverspeedCounter}/10)");

                if (criticalOverspeedCounter >= 10)
                {
                    Console.WriteLine("[Патрульный] ТРЕВОГА! Вызывается спецгруппа для остановки опасного нарушителя!");
                    criticalOverspeedCounter = 0; 
                }
            }
            else
            {
                Console.WriteLine($"[Патрульный] Скорость {speed} км/ч: В пределах нормы.");
                criticalOverspeedCounter = 0; 
            }
        }
    }
}