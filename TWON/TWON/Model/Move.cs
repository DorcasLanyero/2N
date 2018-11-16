using System;
using System.Collections.Generic;
using System.Text;

namespace TWON.Model
{
	// This class represents a move that a Tile performs.  Provides a simple way to communicate which pieces were moved.
    public class Move
    {
		// Original index of piece to be moved
		public int i;

		// Tile moved
		Tile tile;

		// Original position
		// { x: x-coordinate, y: y-coordinate }
		int[] Position;

		// New position
		// { x: x-coordinate, y: y-coordinate }
		int[] NewPosition;

		public Move (int i, Tile tile, int[] position, int[] newPosition)
		{
			this.i = i;
			this.tile = tile;
			this.Position = position;
			this.NewPosition = newPosition;
		}
    }
}
