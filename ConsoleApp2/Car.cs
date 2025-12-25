using System;
using System.Collections.Generic;
using System.Threading;

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

        public void IncreaseSpeedGradually()
        {
            for (float s = 10; s <= 200; s += 10)
            {
                SetSpeed(s);
                Thread.Sleep(300);
                Console.WriteLine($"Текущая скорость: {s} км/ч");
            }
        }
    }
}