using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	abstract class Person
	{
		public double Money { get; protected set; }
		public string Name { get; protected set; }

		public Person(string name, double money)
		{
			Money = money;
			Name = name;
		}
		public Person(string name) : this(name, 0) { }
		public Person(double money) : this("John Doe", money) { }
		public Person() : this(0) { }
	}

}
