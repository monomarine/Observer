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
            car.SpeedIncrease(50);
        }
    }
}
