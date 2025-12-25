using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class LongTermSpeedMonitor : IObserver
    {
        private Queue<float> speedHistory = new Queue<float>();
        private const int MAX_HISTORY = 10;
        private const float SPEED_LIMIT = 150f;

        public void Update(float speed)
        {
            speedHistory.Enqueue(speed);

            if (speedHistory.Count > MAX_HISTORY)
                speedHistory.Dequeue();

            if (speedHistory.Count == MAX_HISTORY)
            {
                bool allExceed = true;
                foreach (var pastSpeed in speedHistory)
                {
                    if (pastSpeed <= SPEED_LIMIT)
                    {
                        allExceed = false;
                        break;
                    }
                }

                if (allExceed)
                {
                    Console.WriteLine($"\nВНИМАНИЕ! Автомобиль превышает {SPEED_LIMIT} км/ч {MAX_HISTORY} раз подряд!");
                }
            }
        }
    }
}