using System.Collections.Generic;

namespace TWON
{
	class HighScore
	{
		//Holds names of players and their high scores.
		private Dictionary<string, int> High_Score { get; set; }

		//Constructor for the Highscore class
		public HighScore()
		{

		}

		//Checks if player's score is a highscore.
		public bool CheckIfHighScore()
		{
			return false;
		}

		//Adds a player's name and score to  high score file
		public void AddToFile()
		{

		}

		//Returns all the high scores and correspoinding player names from a file
		public string GetFromFile()
		{
			return "Player names and high scores";
		}

		//Returns the best score from a file to be displayed on the leader board. 
		public string BestScore()
		{
			return "The best score";
		}
	}
}
