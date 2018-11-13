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

			InitializeComponent ();
			
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

			InitializeComponent();
		}

		private void OnStartTapped(object sender, EventArgs e)
		{
			App.Current.MainPage = new GamePage();

		}
	}
}
