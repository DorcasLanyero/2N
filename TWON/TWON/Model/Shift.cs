using System;
using System.Collections.Generic;
using System.Text;

namespace TWON.Model
{
	// This class represents a move that a Tile performs.  Provides a simple way to communicate which pieces were moved.
    public class Shift : Move
    {
		
		// New position
		public int newIndex;

		public Shift (int i, int newIndex, Tile tile)
		{
			this.i = i;
			this.tile = tile;
			this.newIndex = newIndex;
		}
    }
}
