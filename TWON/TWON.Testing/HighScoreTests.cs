using NUnit.Framework;
using System.Collections.Generic;
using TWON;

namespace TWON.Testing
{
	[TestFixture]
	public class HighScoreTests
	{

		//Tests the CheckIfHighScore method
		[Test]
		public void Test_CheckIfHighScore()
		{
			HighScore NewScore = new HighScore("Dorcas", 5768);
			bool result = NewScore.CheckIfHighScore(NewScore.Name, NewScore.Score);
			Assert.IsTrue(result == true);

		}

		//Tests the GetFromFIle method
		[Test]
		public void Test_Save_Load()
		{	
			HighScore NewScore = new HighScore("Dorcas", 456735);
			NewScore.Save(HighScore.HighScores);
			List<string> result = NewScore.Load();
			string results = result[0];
			Assert.IsTrue(results == "1 Dorcas 456735");
		}

		//Tests the BestScore method
		[Test]
		public void Test_BestScore()
		{
			//return "The best score";
		}

		
		
	}
}
