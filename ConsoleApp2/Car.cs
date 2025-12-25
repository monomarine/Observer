using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Car : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float speed;
        private int over150Counter = 0;

        public void RegisterObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);

        public void NotifyObservers()
        {
            // Проверяем длительное превышение
            if (speed > 150)
            {
                over150Counter++;
                if (over150Counter >= 10)
                {
                    Console.WriteLine($"ВНИМАНИЕ: Скорость {speed} км/ч держится уже {over150Counter} раз!");
                }
            }
            else
            {
                over150Counter = 0;
            }

            foreach (var observer in observers)
                observer.Update(speed);
        }

        public void SetSpeed(float newSpeed)
        {
            speed = newSpeed;
            NotifyObservers();
        }

        // Новый метод: плавное увеличение скорости
        public void GraduallyIncreaseSpeed()
        {
            for (float s = 10; s <= 200; s += 10)
            {
                SetSpeed(s);
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}