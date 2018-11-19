using System;
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
		public event EventHandler<List<Move>> UpdateBoardEvent;
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
			int finalIndex = i;
			bool combination = false;
			bool pieceShifted = true;
			while (pieceShifted)
			{

				// going up = subtracting _columns
				// going down = adding _columns
				// going left = subtracting one
				// going right = adding one
				int testIndex;
				switch (d)
				{
					case Direction.Down:
						testIndex = i + _columns;
						break;
					case Direction.Up:
						testIndex = i - _columns;
						break;
					case Direction.Left:
						testIndex = i - 1;
						break;
					case Direction.Right:
						testIndex = i + 1;
						break;
					default:
						throw new System.Exception("Invalid direction");
				}

				if (Tiles[testIndex].Value == 0)
				{
					// If a position is empty
					finalIndex = testIndex;
				}
				else if (Tiles[testIndex].Value == Tiles[i].Value)
				{
					// If the tile can be combined
					combination = true;
				}
				else
				{
					pieceShifted = false;
				}
			}

			if (finalIndex != i)
			{
				if (combination)
				{
					return new Combination(i, finalIndex, Tiles[i]);
				} else
				{
					return new Shift(i, finalIndex, Tiles[i]);
				}
				
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
		public int PlaceTile()
		{
			while (!GameOver)
			{
				int i = rand.Next(_gridSize);
				Tile tile = Tiles[i];

				if (tile.Value == 0)
				{
					tile.Value = 2;
					return i;
				}
			}

			return -1;
		}

		// shift all tile values on the grid in the given direction
		public List<Move> ShiftTiles(Direction dir)
		{
			List<Move> moves = new List<Move>();
			if (dir == Direction.Down || dir == Direction.Right)
			{
				// Count i down
			} else
			{
				// Count i up
			}

			// Move into if statement
			for (int i = 0, row, col; i < _gridSize; ++i)
			{
				row = GetRow(i);
				col = GetColumn(i);

				

				if (GetDirections()[i].Contains(dir))
				{
					moves.Add(MoveTile(i, dir));
				}
			}

			int newTile = PlaceTile();
			moves.Add(new Spawn(newTile, Tiles[newTile]));
			

			return moves;
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
