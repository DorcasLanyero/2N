using TWON.API;

namespace TWON
{
	class Game : IGameData
	{
		public Tile[,] Tiles { get; private set; }

		public Game(int maxTileValue)
		{
			Tiles = new Tile[maxTileValue, maxTileValue];

			for (int x = 0; x < maxTileValue; ++x)
			{
				for (int y = 0; y < maxTileValue; ++y)
				{
					Tiles[x, y] = new Tile();
				}
			}
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
