namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();

            car.RegisterObserver(officer);

            for (int i = 0; i < 12; i++)
            {
                car.SetSpeed(160); \
            }
        }
    }
}
