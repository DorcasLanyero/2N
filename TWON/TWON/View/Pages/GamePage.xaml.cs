using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TWON.View.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
		public GamePage()
		{
			InitializeComponent();

			var GameModelGrid = new Grid();

			GameModelGrid.PlaceTile();

			int i = 0;  // Yes I know this is convoluted
			foreach (Tile tile in GameModelGrid.Tiles)
			{
				GameGrid.Children.Add(CreateTile(tile.Value, tile.GetColor()), GameModelGrid.GetRow(i), GameModelGrid.GetColumn(i));
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
	}
}
