namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();
            LongTermSpeedMonitor monitor = new LongTermSpeedMonitor();

            car.RegisterObserver(officer);
            car.RegisterObserver(monitor);

            Console.WriteLine("Запуск постепенного увеличения скорости\n");

            car.IncreaseSpeedGradually();

            Console.WriteLine("\nДостигнута максимальная скорость \n");

            Console.WriteLine("Продолжаем движение на высокой скорости");
            for (int i = 0; i < 12; i++)
            {
                car.SetSpeed(180);
                Console.WriteLine($"Скорость: 180 км/ч (измерение {i + 1})");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nТест завершен");
            Console.ReadKey();
        }
    }

}
