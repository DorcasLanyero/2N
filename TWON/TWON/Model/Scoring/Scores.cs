using System;
using System.Collections.Generic;
using System.Text;

namespace TWON
{
    class Scores
    {
		int Score = 0;
		public Scores()
		{

		}

		//Takes the of tiles hat have been summed and adds them to the current score. 
		public void ComputeSCore(int value)
		{
			Score += value;

		}

		//Return the current score.
		public int GetScore()
		{
			return Score;
		}

    }
}
