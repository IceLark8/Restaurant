using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	class Client : Person
	{
		public Client(string name, double money):base(name, money) { }

		public void VisitRestaurant() { }
	}
}
