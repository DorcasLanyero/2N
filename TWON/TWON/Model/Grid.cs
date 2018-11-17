using System.Collections.Generic;
using System.Linq;
using TWON.Model;
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
		public bool GameOver => Tiles.All(tile => tile.Value > 0);

		public bool cheatMode = false;

		protected static CryptoRandom rand = new CryptoRandom();

		private readonly int _columns;
		private readonly int _gridSize;

		public Grid(int size)
		{
			_columns = size;
			_gridSize = size * size;
			Tiles = new Tile[_gridSize];

			for (int i = 0; i < _gridSize; ++i)
			{
				Tiles[i] = new Tile();
			}
		}

		public Grid() : this(4) { }

		public Grid(int size, bool cheatMode) : this(size)
		{
			this.cheatMode = cheatMode;
		}

		// row # of item at idx
		public int GetRow(int idx)
		{
			return idx / _columns;
		}

		// column # of item at idx
		public int GetColumn(int idx)
		{
			return idx % _columns;
		}

		public Move MoveTile(int i, Direction d)
		{
			int[] initialPosition = { GetRow(i), GetColumn(i) };
			int[] finalPosition = initialPosition;
			bool pieceShifted = true;
			while (pieceShifted)
			{
				switch (d)
				{
					case Direction.Down:
						if (Tiles[i + _gridSize].Value == 0)
						{
							finalPosition = new int[] { GetRow(i + _gridSize), GetColumn(i + _gridSize) };
						} else
						{
							pieceShifted = false;
						}
						break;
					case Direction.Up:
						if (Tiles[i - _gridSize].Value == 0)
						{
							finalPosition = new int[] { GetRow(i - _gridSize), GetColumn(i - _gridSize) };
						}
						else
						{
							pieceShifted = false;
						}
						break;
					case Direction.Left:
						if (Tiles[i - 1].Value == 0)
						{
							finalPosition = new int[] { GetRow(i - 1), GetColumn(i - 1) };
						}
						else
						{
							pieceShifted = false;
						}
						break;
					case Direction.Right:
						if (Tiles[i + 1].Value == 0)
						{
							finalPosition = new int[] { GetRow(i + 1), GetColumn(i + 1) };
						}
						else
						{
							pieceShifted = false;
						}
						break;
					default:
						throw new System.Exception("Invalid direction");
				}
			}

			if (finalPosition != initialPosition)
			{
				return new Move(
					i,
					Tiles[i],
					initialPosition,
					finalPosition);
			} else
			{
				return null;
			}
		}
		

		// use memoization so we don't have to iterate every time we call GetDirections()
		private readonly List<HashSet<Direction>> Dir_Memos = new List<HashSet<Direction>>();

		public List<HashSet<Direction>> GetDirections()
		{
			if (Dir_Memos.Count == 0)
			{
				for (int i = 0, row, col; i < _gridSize; ++i)
				{
					row = GetRow(i);
					col = GetColumn(i);
					var set = new HashSet<Direction>();

					if (row == 0)
					{
						set.Add(Down);
					}
					else if (row == _columns - 1)
					{
						set.Add(Up);
					}
					else
					{
						set.Add(Up);
						set.Add(Down);
					}

					if (col > 0)
					{
						set.Add(Left);
					}

					if (col < _columns - 1)
					{
						set.Add(Right);
					}

					Dir_Memos.Add(set);
				}
			}

			return Dir_Memos;
		}

		// randomly place one 2 on an empty tile
		public bool PlaceTile()
		{
			while (!GameOver)
			{
				Tile tile = Tiles[rand.Next(_gridSize)];

				if (tile.Value == 0)
				{
					tile.Value = 2;
					break;
				}
			}

			return GameOver;
		}

		// shift all tile values on the grid in the given direction
		public void ShiftTiles(Direction dir)
		{
			for (int i = 0, row, col; i < _gridSize; ++i)
			{
				row = GetRow(i);
				col = GetColumn(i);

				// going up = subtracting _columns
				// going down = adding _columns
				// going left = subtracting one
				// going right = adding one

				if (GetDirections()[i].Contains(dir))
				{

				}
			}

			PlaceTile();
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
