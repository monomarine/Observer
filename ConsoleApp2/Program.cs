namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();

            car.RegisterObserver(officer);

            Console.WriteLine("Тест 1: Ручное управление скоростью");
            car.SetSpeed(90);
            car.SetSpeed(110);
            car.SetSpeed(160);

            Console.WriteLine("\nТест 2: Плавный разгон 10-200 км/ч");
            car.GraduallyIncreaseSpeed();

            // Демонстрация длительного превышения
            Console.WriteLine("\nТест 3: Длительное превышение 155 км/ч");
            for (int i = 0; i < 12; i++)
                car.SetSpeed(155);
        }
    }
}