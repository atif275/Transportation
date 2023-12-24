using System;
namespace FactoryPattern
{
	class Car:IVehicle
	{
        private readonly int Wheels;

        public Car()
        {
            this.Wheels = 4;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Car class";
        }
    }
}

