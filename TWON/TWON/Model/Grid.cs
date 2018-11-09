using System.Collections.Generic;
using static TWON.Direction;

namespace TWON
{
	public enum Direction
	{
		Up, Down, Left, Right
	}

	public class Grid
	{
		public Tile[] Tiles { get; set; }
		private readonly int _columns;
		private readonly int _gridSize;

		protected static CryptoRandom rand = new CryptoRandom();
		public List<List<Direction>> directions = new List<List<Direction>>()
		{
			/*
			 * Attempt checking clockwise
			 * 
			 * [00, 01, 02, 03]
			 * [04, 05, 06, 07]
			 * [08, 09, 10, 11]
			 * [12, 13, 14, 15]
			 */
			new List<Direction>() { Right, Down },
			new List<Direction>() { Right, Down, Left },
			new List<Direction>() { Right, Down, Left },
			new List<Direction>() { Down, Left },

			new List<Direction>() { Up, Right, Down },
			new List<Direction>() { Up, Right, Down, Left },
			new List<Direction>() { Up, Right, Down, Left },
			new List<Direction>() { Up, Down, Left },

			new List<Direction>() { Up, Right, Down },
			new List<Direction>() { Up, Right, Down, Left },
			new List<Direction>() { Up, Right, Down, Left },
			new List<Direction>() { Up, Down, Left },

			new List<Direction>() { Up, Right },
			new List<Direction>() { Up, Right, Left },
			new List<Direction>() { Up, Right, Left },
			new List<Direction>() { Up, Left },
		};

		public Grid(int max)
		{
			_columns = max;
			_gridSize = max * max;
			Tiles = new Tile[_gridSize];

			for (int i = 0; i < _gridSize; ++i)
			{
				Tiles[i] = new Tile();
			}
		}

		public Grid() : this(4) { }

		// row # of item at idx
		private int GetRow(int idx)
		{
			return idx / _columns;
		}

		// column # of item at idx
		private int GetColumn(int idx)
		{
			return idx % _columns;
		}

		// randomly place one 2 on an empty tile
		public void PlaceTile()
		{
			bool searching = true;

			while (searching)
			{
				Tile tile = Tiles[rand.Next(_gridSize)];

				if (tile.Value == 0)
				{
					tile.Value = 2;
					searching = false;
				}
			}
		}

		// shift all tile values on the grid in the given direction
		public void ShiftTiles(Direction dir)
		{

		}

		public string Save()
		{
			return this.XmlSerializeToString();
		}

		public Grid Load(string data)
		{
			return data.XmlDeserializeFromString<Grid>();
		}
	}
}
