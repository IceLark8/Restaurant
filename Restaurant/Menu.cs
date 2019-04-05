using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
	class Menu
	{
		public List<Dish> Dishes = new List<Dish>() { };

		public Menu(params Dish[] dishes)
		{
			Dishes.AddRange(dishes);
		}
		public IEnumerator<Dish> GetEnumerator()
		{
			return Dishes.GetEnumerator();
		}

		//ienumerator ienumerable.getenumerator()
		//{
		//	return (ienumerator)dishes.getenumerator();
		//}
	}

	class Dish
	{
		public string Name { get; private set; }
		public double Weight { get; private set; }
		public double Price { get; private set; }

		public Dish(string name, double weight, double price)
		{
			Name = name;
			Weight = weight;
			Price = price;
		}

		public override string ToString()
		{
			return $"{Name} \t----\t {Price} UAH per 100 gr. // {Weight} gr.";
		} 
	}
}
