using System;
namespace FactoryPattern
{
	public class Rickshaw:IVehicle
	{
        private readonly int Wheels;

        public Rickshaw()
        {
            this.Wheels = 3;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Rickshaw class";
        }
    }
}

