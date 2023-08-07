namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have that you would like to build?");
            var userInput = int.TryParse(Console.ReadLine(), out int numOfTires);
            var vehicle = VehicleFactory.GetVehicle(numOfTires);
            vehicle.Drive();
        }
    }
}
