using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWON
{
	public class Program
	{
		static void Main(string[] args)
		{
			Grid grid = new Grid();
			grid.PlaceTile();
			Console.WriteLine(grid.Save());
		}
	}
}
