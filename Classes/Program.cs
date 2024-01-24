namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Nissan";
            myCar.Model = "Pathfinder";
            myCar.Year = 2016;

            Console.WriteLine($"{myCar.Year} {myCar.Make} {myCar.Model} ");

        }
    }
}
