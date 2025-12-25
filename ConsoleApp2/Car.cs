using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    public class Car : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float speed;

        public void RegisterObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update(speed);
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
            NotifyObservers();
        }

        public void GradualSpeedIncrease()
        {
            int overSpeedCount = 0;

            for (float s = 10; s <= 200; s += 10)
            {
                SetSpeed(s);

                if (s > 150) overSpeedCount++;
                else overSpeedCount = 0;

                if (overSpeedCount >= 10)
                    Console.WriteLine("Скорость >150 км/ч держится 10 итераций.");

                Thread.Sleep(100);
            }
        }
    }
}
