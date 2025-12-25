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
            speed = 0;
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

        public void UvelichenieSpeed()
        {
            Random random = new Random();
            float current = 10;

            for(int i = 0; i < 10; i++)
            {
                current += random.Next(5, 50);

                if (current >200) current = 200;
                if (current <10) current = 10;

                Console.WriteLine($" скорость {current}");
                SetSpeed(current);
            }
        }
    }
}

