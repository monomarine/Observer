using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Car : ISubject
    {
        private List<IObserver> observers;
        private float speed;
        private int over150Count;

        public Car()
        {
            observers = new List<IObserver>();
            over150Count = 0;
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
                over150Count++;
                if (over150Count >= 10)
                {
                    Console.WriteLine("Внимание! Скорость >150 уже " + over150Count + " раз");
                }
            }
            else
            {
                over150Count = 0;
            }

            NotifyObservers();
        }

        public void IncreaseGradually()
        {
            for (int i = 10; i <= 200; i += 10)
            {
                SetSpeed(i);
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}