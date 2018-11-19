using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWON.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TWON.View.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
		Grid Model;
		public GamePage()
		{
			InitializeComponent();

			var Model = new Grid();

			Model.PlaceTile();

			int i = 0;  // Yes I know this is convoluted
			foreach (Tile tile in Model.Tiles)
			{
				GameGrid.Children.Add(CreateTile(tile.Value, tile.GetColor()), Model.GetRow(i), Model.GetColumn(i));
				i++;
			}

			
		}

		public StackLayout CreateTile (int value, Color color)
		{
			var RootEl = new StackLayout();

			var Background = new BoxView();

			Background.WidthRequest = 50;
			Background.HeightRequest = 50;
			Background.BackgroundColor = color;

			var label = new Label
			{
				Text = Convert.ToString(value),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				FontSize = 20,
				TranslationY = -45
			};



			RootEl.Children.Add(Background);
			if (value > 0) RootEl.Children.Add(label);

			return RootEl;
		}

		private void BackButton_Clicked(object sender, EventArgs e)
		{
			App.Current.MainPage = new StartPage();
		}

		private void MoveTiles(List<Move> moves)
		{
			foreach (Move move in moves)
			{
				int x = Model.GetColumn(move.i);
				int y = Model.GetRow(move.i);


			}
		}

		private void MoveDown(object sender, EventArgs e)
		{

		}

		private void MoveUp(object sender, EventArgs e)
		{

		}

		private void MoveLeft(object sender, EventArgs e)
		{

		}

		private void MoveRight(object sender, EventArgs e)
		{

		}
	}
}
