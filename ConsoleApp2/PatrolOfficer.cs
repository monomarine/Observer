using System;

namespace ConsoleApp2
{
    public class PatrolOfficer : IObserver
    {
        public void Update(float speed)
        {
            if (speed > 100 && speed <= 150)
                Console.WriteLine($"Скорость {speed} км/ч - превышение! Патрульный выезжает.");
            else if (speed > 150)
                Console.WriteLine($"Скорость {speed} км/ч - ОПАСНОЕ превышение!");
            else
                Console.WriteLine($"Скорость {speed} км/ч - норма.");
        }
    }
}