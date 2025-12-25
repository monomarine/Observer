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

            Console.WriteLine("\nПостепенный разгон ");
            car.IncreaseGradually();

            Console.WriteLine("\n Проверка долгого превышения ");
            for (int i = 0; i < 12; i++)
            {
                car.SetSpeed(160);
            }
        }
    }
}