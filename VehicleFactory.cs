using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public static IVehicle getVahicle(String Type)
		{
			IVehicle ObjectType = null;
			if (Type.ToLower().Equals("bike"))
			{
				ObjectType = new Bike();

            }
            else if (Type.ToLower().Equals("car"))
            {
                ObjectType = new Car();

            }
            else if (Type.ToLower().Equals("rickshaw"))
            {
                ObjectType = new Rickshaw();

            }
            else if (Type.ToLower().Equals("bus"))
            {
                ObjectType = new Bus();

            }
            else if (Type.ToLower().Equals("truck"))
            {
                ObjectType = new Truck();

            }
            return ObjectType;
        }
	}
}

