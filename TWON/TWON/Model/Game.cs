using TWON.API;

namespace TWON
{
	public enum Direction
	{
		Up, Down, Left, Right
	}

	public class Game : IGameData
	{
		public Tile[] Tiles { get; set; }
		private readonly int _columns;

		public Game(int max)
		{
			_columns = max;
			int gridSize = max * max;
			Tiles = new Tile[gridSize];

			for (int i = 0; i < gridSize; ++i)
			{
				Tiles[i] = new Tile();
			}
		}

		public Game() : this(4) { }

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

		public void PlaceTiles()
		{
			// randomly change tile values to 2 on the grid
		}

		public void ShiftTiles(Direction dir)
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
