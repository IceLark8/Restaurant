using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
			Dish salad = new Dish("Salad", 0.2, 25);
			Dish soup = new Dish("Soup", 0.5, 20);
			Dish beef = new Dish("Beef", 0.5, 70);
			Menu FirsRestaurantMenu = new Menu(salad, soup, beef);

			foreach(Dish a in FirsRestaurantMenu)
			{
				Console.WriteLine(a);
			}

			Console.ReadKey();
		}

		public static void Wait()
		{
			Thread.Sleep(10000);
			Console.WriteLine("LOOOOOOOOOOOOOOOL");
		}
    }
}
