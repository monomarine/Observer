using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        }

        public void GraduallyIncreaseSpeed()
        {
            int startSpeed = 10;
            int endSpeed = 200;
            int step = 10;
            int delayMs = 300; 

            Console.WriteLine($"Начинаем разгон с {startSpeed} до {endSpeed} км/ч:");

            for (int currentSpeed = startSpeed; currentSpeed <= endSpeed; currentSpeed += step)
            {
                SetSpeed(currentSpeed);
                if (currentSpeed > 150)
                {
                    overspeedCounter++;
                    Console.WriteLine($"[Автомобиль] Превышение >150 км/ч: {overspeedCounter}/10 итераций");

                    if (overspeedCounter >= 10)
                    {
                        Console.WriteLine($"[Автомобиль] ВНИМАНИЕ! Превышение >150 км/ч продолжается {overspeedCounter} итераций подряд!");
                        overspeedCounter = 0;
                    }
                }
                else
                {
                    overspeedCounter = 0; 
                }

                Thread.Sleep(delayMs); 
            }

            Console.WriteLine("[Автомобиль] Достигнута максимальная скорость 200 км/ч");
        }
    }
}