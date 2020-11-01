using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarWorld
{
	public class Company : IEnumerable
	{
		private readonly List<Car> _cars;
		public string Name { get; set; }
		public readonly int Year;

		public Company(string name, int year)
		{
			Year = year;
			Name = name;
			_cars = new List<Car>();
		}
		public override string ToString()
		{
			return $"Компания {Name} основана в {Year}";
		}

		public static void CarCreated(Car car)
		{
			CompanyFactory.Companies[car.Company.Name]._cars.Add(car);
		}

		#region IEnumerator/Indexator
		public Car this[int index]
		{
			get => _cars[index];
			set => _cars[index] = value;
		}

		public IEnumerator<Car> GetEnumerator()
		{
			return _cars.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _cars.GetEnumerator();
		}
		#endregion
	}
}
