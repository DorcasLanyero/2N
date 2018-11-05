using TWON.API;

namespace TWON
{
<<<<<<< HEAD
	class Game : IGameData
	{
		public Tile[,] Tiles { get; private set; }
=======
	public enum Direction
	{
		Up, Down, Left, Right
	}

	public class Game : IGameData
	{
		public Tile[] Tiles { get; set; }
		private readonly int _columns;
>>>>>>> 95b6842e817730493b1d142775607760da5fc078

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

<<<<<<< HEAD
		public void ShiftTiles()
=======
		// row # of item at idx
		private int GetRow(int idx)
>>>>>>> 95b6842e817730493b1d142775607760da5fc078
		{
			// shift all tiles on the grid in the given direction
		}

<<<<<<< HEAD
		public string Save()
=======
		// column # of item at idx
		private int GetColumn(int idx)
>>>>>>> 95b6842e817730493b1d142775607760da5fc078
		{
			return this.XmlSerializeToString();
		}

		public IGameData Load(string data)
		{
			return data.XmlDeserializeFromString<Game>();
		}
	}

<<<<<<< HEAD
	class CheatMode:Game
	{
		//CheaMode condtructor calls the base constructor
		public CheatMode(int Max):base(Max)
=======
		public void ShiftTiles(Direction dir)
>>>>>>> 95b6842e817730493b1d142775607760da5fc078
		{

		}

		//converts the tiles to be in cheat mode
		public void ActivateCheatMode()
		{

		}

		//Reversts tiles back to normal
		public void DeactivateCheatMode()
		{

		}


	}

}
