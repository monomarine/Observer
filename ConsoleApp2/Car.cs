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
        private int overSpeedCounter; 

        public Car()
        {
            observers = new List<IObserver>();
            overSpeedCounter = 0;
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

        private void NotifyLongOverSpeed()
        {
            foreach (var observer in observers)
            {
                
                observer.Update(-1); 
            }
        }
        public void SetSpeed(float speed)
        {
            this.speed = speed;
            NotifyObservers();


            if (speed > 150)
            {
                overSpeedCounter++;
                if (overSpeedCounter >= 10)
                {
                    NotifyLongOverSpeed();
                    overSpeedCounter = 0;
                }
            }
            else
            {
                overSpeedCounter = 0;
            }
        }

        public void LongIncreaseSpeed(int steps)
        {
            float startSpeed = 10;
            float endSpeed = 200;
            float step = (endSpeed - startSpeed) / steps;

            for (int i = 0; i <= steps; i++)
            {
                float currentSpeed = startSpeed + step * i;
                SetSpeed(currentSpeed);
                
            }


        }
    }    
}
