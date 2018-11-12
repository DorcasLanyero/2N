using System;
using System.Collections.Generic;
using System.Text;
using TWON.View.Pages;
using Xamarin.Forms;

namespace TWON
{
    public class MainPage : ContentPage
    {
		StackLayout MainLayout = new StackLayout();
		public MainPage()
		{

			Button GameBtn = new Button();
			GameBtn.Text = "Start Game";
			GameBtn.Clicked += GameBtn_Clicked;
			MainLayout.Children.Add(GameBtn);

			// https://stackoverflow.com/questions/24929977/add-a-child-to-the-parent-on-button-click-xamarin-forms
			Content = MainLayout; 
		}

		private void GameBtn_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new StartPage();
		}
	}
}
