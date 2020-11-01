using System;
using System.Collections.Generic;
using System.Text;

namespace CarWorld
{
	
	public class Car
	{
		public readonly Company Company;
		public Engine Engine { get; set; }
		public string Name { get; set; }
		public int CountOfWheel { get; set; }
		public readonly int Year;

		public Car(Company company, Engine engine, string name, int year, int countOfWheel)
		{
			Company = company;
			Year = year;
			Name = name;
			CountOfWheel = countOfWheel;
			Engine = engine;
		}

		public override string ToString()
		{
			return $"\n\tМашина" +
			       $"\n\tКомпания:\t{Company.Name}" +
			       $"\n\tНазвание:\t{Name}" +
			       $"\n\tДвигатель:\t{Engine}" +
			       $"\n\tГод выпуска:\t{Year}" +
			       $"\n\tКол-во колёс:\t{CountOfWheel}";
		}
	}
}
