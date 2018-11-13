using System;

namespace TWON
{
	public class Program
	{
		static void Main(string[] args)
		{
			Grid grid = new Grid();
			//grid.PlaceTile();
			//Console.WriteLine(grid.Save());
			var dirs = grid.GetDirections();

			foreach (var set in dirs)
			{
				foreach (var dir in set)
				{
					Console.Write(dir.ToString() + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
