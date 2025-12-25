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
        private int overspeedCounter;

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
                overspeedCounter++;
                if (overspeedCounter >= 10)
                {
                    Console.WriteLine("\nПревышение скорости более 150 км/ч продолжается 10 раз подряд!\n");
                    overspeedCounter = 0;
                }
            }
            else
            {
                overspeedCounter = 0;
            }

            NotifyObservers();
        }

        public void GraduallyIncreaseSpeed()
        {

            for (int i = 10; i <= 200; i += 10)
            {
                SetSpeed(i);
            }
        }
    }

}

