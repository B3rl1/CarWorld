using System;
using System.Collections.Generic;
using System.Text;

namespace CarWorld
{
	public delegate void CarCreated(Car car);
	class CarFactory
	{
		public event CarCreated CarCreatedEvent;
		public Car CreateCar(Company company, Engine engine, string name, int year, int countOfWheel)
		{
			var res = new Car(company, engine, name, year, countOfWheel);
			CarCreatedEvent?.Invoke(res);
			return res;
		}
	}
}