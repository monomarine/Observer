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
        private int speedOver150Counter; 

        public Car()
        {
            observers = new List<IObserver>();
            speedOver150Counter = 0;
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

            if (speed > 150)
            {
                speedOver150Counter++;
                if (speedOver150Counter >= 10)
                {
                    Console.WriteLine($"ВНИМАНИЕ: Превышение скорости более 150 км/ч продолжается уже {speedOver150Counter} раз подряд!");
                }
            }
            else
            {
                speedOver150Counter = 0; 
            }
        }

        public void GraduallyIncreaseSpeed()
        {
            Console.WriteLine("\n Постепенное увеличение скорости");

            for (int currentSpeed = 10; currentSpeed <= 200; currentSpeed += 10)
            {
                SetSpeed(currentSpeed); 
                System.Threading.Thread.Sleep(200); 
            }

            Console.WriteLine(" Разгон завершен \n");
        }
    }
}