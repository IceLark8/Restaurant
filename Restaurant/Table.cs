using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	class Table
	{
		public byte Number { get; private set; }
		public Client Client { get; private set; }
		public bool VIP { get; private set; }


		public Table(byte number, Client client, bool vip = false)
		{
			Number = number;
			Client = client;
			VIP = vip;
		}
		public Table(byte number):this(number, null) { }
		
	}
}
