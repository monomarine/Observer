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
        //постепенное увеличение скорости до 200 за 12 итераций
        public void IncreaseSpeed()
        {
            if (speed >= 10 && speed < 200)
            {
                float increase = (200 - speed) / 12;

                while (speed < 200)
                {
                    if (speed + increase <= 200)
                    {
                        SetSpeed(speed + increase);
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
