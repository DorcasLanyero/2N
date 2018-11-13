using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWON.View.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
<<<<<<< HEAD
			InitializeComponent ();
			StartImage.GestureRecognizers
		}

		private void About_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new AboutScreen();

		}

		private void Difficulty_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new DifficultyScreen();

		}

		private void Help_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new HelpScreen();

		}

		private void Cheat_Clicked(object sender, EventArgs e)
		{
			//Implemet cheat 
=======
			InitializeComponent();
		}

		private void OnStartTapped(object sender, EventArgs e)
		{
			App.Current.MainPage = new GamePage();
>>>>>>> 39a92d5c696731f56c13977f08e073e630c372d4
		}
	}
}
