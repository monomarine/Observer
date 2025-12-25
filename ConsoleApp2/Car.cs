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
        private int overSpeedCounter;

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
            NotifyObservers();
        }

        public void Boost()
        {
            for (int i = 10; i <= 200; i += 4)
            {
                SetSpeed(i);

                if (i > 150)
                {
                    overSpeedCounter++;
                    if (overSpeedCounter >= 10)
                    {
                        Console.WriteLine("Внимание! Превышение скорости более 150 км/ч длится слишком долго! Скорость равна " + speed + "км/ч");
                        overSpeedCounter = 0;
                    }
                }
                else
                {
                    overSpeedCounter = 0;
                }
            }
        }

    }
}
