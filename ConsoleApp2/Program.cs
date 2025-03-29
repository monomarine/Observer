namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            PatrolOfficer officer = new PatrolOfficer();

            car.RegisterObserver(officer);


            // увеличение скорости от 10 до 200 
            for (int i = 10; i <= 200; i += 10)
            {
                car.SetSpeed(i);
            }

            // доп итерации чтоб накопить 10 превышений
            for (int i = 0; i < 5; i++)
            {
                car.SetSpeed(200);
            }

            car.RemoveObserver(officer); 


        }

    }
}

