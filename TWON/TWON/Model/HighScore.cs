using System.Collections.Generic;
using System.IO;

namespace TWON
{
	public class HighScore
	{
		public static List<HighScore> HighScores = new List<HighScore>();
		public string Name { get; set; }
		public int Score { get; set; }
		static int CurrentHighestScore;

		//Constructor for the Highscore class
		public HighScore(string name, int score)
		{
			this.Name = name;
			this.Score = score;
		}

		//Checks if player's score is a highscore.
		public bool CheckIfHighScore(string RecievedName, int RecievedScore)
		{
			bool High = false;
			int Counter = 0;
			HighScore NewHighScore;

			while (High == false || HighScores.Count == 0)
			{
				HighScore item = HighScores[Counter];
				if (item.Score < RecievedScore)
				{
					NewHighScore = new HighScore(RecievedName, RecievedScore);
					HighScores.Add(NewHighScore);
					High = true;
				}
				++Counter;
			}

			return High;
		}
		public void OrganiseList()
		{
			int MaximumSize = 10;
			if (HighScores.Count > MaximumSize)
			{
				int LeastScore = 0;
				HighScore Smallest = null;
				foreach (HighScore item in HighScores)
				{
					if (item.Score < LeastScore)
					{
						LeastScore = item.Score;
						Smallest = item;
					}
				}
				HighScores.Remove(Smallest);
			}
			//sort list by scores
		}

		//Adds a player's name and score to  high score file
		public void Save()
		{ int count = 1;
			foreach(HighScore score in HighScores)
			{
				string data = count.ToString() + ' ' + score.Name + ' ' + score.Score;
				using (StreamWriter writer = new StreamWriter("HighScores.txt"))
				{
					writer.WriteLine(data);
				}
				++count;
			}
		}

		//Returns all the high scores and correspoinding player names from a file
		public List<string> Load()
		{
			List<string> HighScoreData = new List<string>();
			string line = "nothing yet";
			while (line != "" && line != null)
			{
				using (StreamReader rd = new StreamReader("HighScores.txt"))
				{
					line = rd.ReadLine();
					HighScoreData.Add(line);
				}
			}

			return HighScoreData;
		}

		//Returns the best score from a file to be displayed on the leader board. 
		public string SetBestScore(int NewScore)
		{
			if (NewScore > CurrentHighestScore)
			{
				CurrentHighestScore = NewScore;
			}
			return NewScore.ToString();
		}
	}
}
