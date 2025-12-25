namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();

            car.RegisterObserver(officer);

            Console.WriteLine("=== Тестирование системы отслеживания скорости ===\n");
            car.GraduallyIncreaseSpeed();
            Console.WriteLine("\n=== Тест завершён ===");
            Console.ReadKey();
        }
    }
}