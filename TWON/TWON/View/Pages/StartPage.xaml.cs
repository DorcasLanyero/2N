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
			InitializeComponent();
		}

		private void OnStartTapped(object sender, EventArgs e)
		{
			App.Current.MainPage = new GamePage();
		}
	}
}
