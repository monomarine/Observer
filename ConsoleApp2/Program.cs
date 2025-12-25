namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();

            car.RegisterObserver(officer);

            car.SetSpeed(90);
            car.SetSpeed(110);
            car.SetSpeed(70);

            car.GradualSpeedIncrease();
            for (int i = 0; i < 15; i++)
            {
                car.SetSpeed(160); 
                Console.WriteLine($"Итерация {i + 1}: Установлена скорость 160 км/ч");
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}

