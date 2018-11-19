using System;
using System.Collections.Generic;
using System.Text;

namespace TWON.Model
{
    class Combination : Move
    {
		// Index of piece the active piece is combined with
		public int combinedIndex;

		// The new value of the active piece
		public int newValue;

		public Combination (int i, int comboIndex, Tile activeTile)
		{
			this.i = i;
			this.combinedIndex = comboIndex;
			this.tile = activeTile;
		}
    }
}
