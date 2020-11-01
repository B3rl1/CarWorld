using System;
using System.Collections.Generic;
using System.Text;

namespace CarWorld
{
	public static class CompanyFactory
	{
		public static Dictionary<string, Company> Companies;
		public static Company CreateCompany(string name, int year)
		{
			var res = new Company(name, year);
			Companies.Add(res.Name, res);
			return res;
		}

		static CompanyFactory()
		{
			Companies = new Dictionary<string, Company>();
		}
	}
}
