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

            car.GraduallyIncreaseSpeed();

            car.SetSpeed(160);
            car.SetSpeed(170);
            car.SetSpeed(155);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}