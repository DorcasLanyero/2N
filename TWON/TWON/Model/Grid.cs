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

		public void PlaceTile()
		{
			// randomly place one 2 on an empty tile
			int idx = rand.Next(_gridSize);
			bool searching = true;

			while (searching)
			{
				if (Tiles[idx].Value == 0)
				{
					Tiles[idx].Value = 2;
					searching = false;
				}
			}
		}

		public void ShiftTiles(Direction dir)
		{
			// shift all tile values on the grid in the given direction
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
