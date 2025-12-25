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
            overspeedCounter = 0;
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
                overspeedCounter++;
                if (overspeedCounter >= 10)
                {
                    Console.WriteLine("ВНИМАНИЕ! Превышение скорости более 150 км/ч продолжается 10 итераций!");
                    overspeedCounter = 0; 
                }
            }
            else
            {
                overspeedCounter = 0; 
            }
        }

   
        public void GradualSpeedIncrease()
        {
            for (float s = 10; s <= 200; s += 10)
            {
                SetSpeed(s);
                Console.WriteLine($"Текущая скорость: {s} км/ч");

             
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("Достигнута максимальная скорость 200 км/ч\n");
        }
    }

}

