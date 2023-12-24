using System;
namespace FactoryPattern
{
	public class Bus:IVehicle
	{
        private readonly int Wheels;

        public Bus()
        {
            this.Wheels = 6;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Bus class";
        }
    }
}

