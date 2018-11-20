using System;
using System.Collections.Generic;
using System.Text;

namespace TWON.Model
{
    class Spawn : Move
    {
		public Spawn (int i, Tile tile)
		{
			this.i = i;
			this.tile = tile;
		}
    }
}
