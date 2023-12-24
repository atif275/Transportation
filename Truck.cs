using System;
namespace FactoryPattern
{
	public class Truck:IVehicle
	{
        private readonly int Wheels;

        public Truck()
        {
            this.Wheels = 12;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Truck class";
        }
    }
}

