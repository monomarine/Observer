using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car : ISubject
    {
        private List<IObserver> observers;
        private float speed;
        private int highSpeedCounter = 0;

        public Car()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(speed);
            }
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;

            if (speed > 150)
            {
                highSpeedCounter++;
                Console.WriteLine($"Внимание: скорость {speed} км/ч > 150 (раз: {highSpeedCounter})");

                if (highSpeedCounter >= 10)
                {
                    Console.WriteLine("!!! Превышение 150 км/ч более 10 раз подряд !!!");
                }
            }
            else
            {
                highSpeedCounter = 0;
            }

            NotifyObservers();
        }

        public void GraduallyIncreaseSpeed()
        {
            Console.WriteLine("\nНачинаем постепенное увеличение скорости:");
            for (int s = 10; s <= 200; s += 10)
            {
                SetSpeed(s);
                Console.WriteLine($"Установлена скорость: {s} км/ч");
                System.Threading.Thread.Sleep(300);
            }
            Console.WriteLine("Завершено увеличение скорости.\n");


        }
    }
}