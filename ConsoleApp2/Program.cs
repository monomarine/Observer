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
            car.SetSpeed(200);

            car.RegisterObserver(officer);

            Console.WriteLine("\nПостепенного увеличение скорости\n");
            car.GraduallyIncreaseSpeed();

            Console.WriteLine("\nПовторное нарушение!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");

            for (int i = 0; i < 12; i++)
            {
                car.SetSpeed(160);
            }
        }
    }
}
