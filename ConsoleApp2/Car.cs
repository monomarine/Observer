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
        private int speedExceededCounter;

        public Car()
        {
            observers = new List<IObserver>();
            speedExceededCounter = 0;
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
            CheckLongTermSpeedExceed();
            NotifyObservers();
        }

        public void GraduallyIncreaseSpeed()
        {
            for (float s = 10; s <= 200; s += 5)
            {
                SetSpeed(s);
                Console.WriteLine($"Текущая скорость: {s} км/ч");

            }
        }

        private void CheckLongTermSpeedExceed()
        {
            if (speed > 150)
            {
                speedExceededCounter++;
                if (speedExceededCounter >= 10)
                {
                    Console.WriteLine("Превышение скорости более 150 км/ч продолжается длительное время!");

                    speedExceededCounter = 0;
                }
            }
            else
            {

                speedExceededCounter = 0;
            }
        }
    }

}