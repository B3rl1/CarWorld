using System;
using System.Net.Http;

namespace CarWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			CarFactory carFactory = new CarFactory();
			Company ford = CompanyFactory.CreateCompany("Ford", 1903);
			Engine eng1 = new Engine("EcoBoost V6", 325, 2.7f, Engine.TypeOfFuel.Petrol);

			carFactory.CarCreatedEvent += Company.CarCreated;

			Car car1 = carFactory.CreateCar(ford, eng1, "F-150", 2020, 6);
			Car car2 = carFactory.CreateCar(ford, eng1, "Focus", 2019, 4);

			foreach (var car in ford)
			{
				Console.WriteLine(car.ToString());
			}
		}
	}
}
