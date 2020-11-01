using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWorld
{
	public class Engine
	{
		public enum TypeOfFuel
		{
			Petrol,
			Diesel
		}

		public string Name { get; set; }
		public int HP { get; set; }
		public float Volume { get; set; }
		public TypeOfFuel FuelType { get; set; }

		public Engine(string name, int hp, float volume, TypeOfFuel fuelType)
		{
			Name = name;
			HP = hp;
			Volume = volume;
			FuelType = fuelType;
		}

		public override string ToString()
		{
			return $"\n\t\tНазвание:\t{Name}" +
			       $"\n\t\tЛ.с.:\t{HP}" +
			       $"\n\t\tОбъём:\t{Volume}" +
			       $"\n\t\tТип топлива:\t{FuelType}"; 
		}
	}
}
