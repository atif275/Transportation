using System;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputFromConsole = null;
            Console.WriteLine("Enter vehicle type");
            inputFromConsole = Console.ReadLine();

            while(inputFromConsole != "q")
            {

                IVehicle Type = VehicleFactory.getVahicle(inputFromConsole);
                Console.WriteLine("Type is " + Type.VehicleType());
                Console.WriteLine("Number of wheels = " + Type.NumberOfWheels());
                inputFromConsole = Console.ReadLine();

            }
           
            //Console.ReadKey();
        }
    }
}
