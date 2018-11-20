using System;
using System.Collections.Generic;
using System.Text;

namespace TWON.Model
{
	public abstract class Move
	{
		// Original index of piece to be moved
		public int i;

		// Tile moved
		public Tile tile;
	}
}
