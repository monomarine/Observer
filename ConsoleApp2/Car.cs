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

        public void SetSpeed()
        {
            this.speed = 10;
            
        }
        public void UpdateSpeed()
        {
            while (this.speed < 200)
            {
                this.speed += 10;

                if (this.speed <=110)
                {
                    NotifyObservers();
                }
                
                Console.WriteLine($"Текущая скорость{this.speed}");
                Thread.Sleep(300);
                if (this.speed == 150)
                {
                    Console.WriteLine("Скорость достигла 150");
                }


            }
        }
    }
}
