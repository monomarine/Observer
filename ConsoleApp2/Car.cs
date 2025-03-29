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
        private float overSpeed; //счетчик на скорость выше 150

        public Car()
        {
            observers = new List<IObserver>();
            overSpeed = 0;

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

            Console.WriteLine($"скорость автомобиля: {speed} км/ч ");

            // проверка на длительное превышение  
            if (speed > 150)
            {
                overSpeed++;
                if (overSpeed >= 10)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("превышение скорости более 150 км/ч длится слишком долго! ");
                    Console.ResetColor();
                }
            }
            else
            {
                overSpeed = 0;
            }

            NotifyObservers();
        }
    
}
}
