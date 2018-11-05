using TWON.API;

namespace TWON
{
	public enum EnumFacing
	{
		NORTH, SOUTH, EAST, WEST
	}

	public class Game : IGameData
	{
		public Tile[] Tiles { get; set; }
		private readonly int _columns;

		public Game(int max)
		{
			Tiles = new Tile[max * max];
			_columns = max;

			for (int i = 0; i < max * max; ++i)
			{
				Tiles[i] = new Tile();
			}
		}

		public Game() : this(4) { }

		// row # of item at idx
		private int GetRowIndex(int idx)
		{
			return idx / _columns;
		}

		// column # of item at idx
		private int GetColumnIndex(int idx)
		{
			return idx % _columns;
		}

		public void PlaceTiles()
		{
			// randomly change tile values to 2 on the grid
		}

		public void ShiftTiles(EnumFacing dir)
		{
			// shift all tile values on the grid in the given direction
		}

		public string Save()
		{
			return this.XmlSerializeToString();
		}

		public IGameData Load(string data)
		{
			return data.XmlDeserializeFromString<Game>();
		}
	}
}
