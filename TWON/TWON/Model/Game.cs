using TWON.API;

namespace TWON
{
	class Game : IGameData
	{
		public Tile[,] Tiles { get; private set; }

		public Game(int max)
		{
			Tiles = new Tile[max, max];

			//for (int x = 0; x < maxTileValue; ++x)
			//{
			//	for (int y = 0; y < maxTileValue; ++y)
			//	{
			//		Tiles[x, y] = new Tile();
			//	}
			//}
		}

		public void PlaceTiles()
		{
			// randomly place tiles w/ the value 2 in the grid
		}

		public void ShiftTiles(EnumFacing dir)
		{
			// shift all tiles on the grid in the given direction
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
