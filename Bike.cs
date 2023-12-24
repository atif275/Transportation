﻿using System;
namespace FactoryPattern
{
	class Bike:IVehicle
	{
		private readonly int Wheels;

		public Bike()
		{
			this.Wheels = 2;
		}

		public int NumberOfWheels()
		{
			return this.Wheels;
		}
		public string VehicleType()
		{
			return "Bike class";
		}
	}
}

