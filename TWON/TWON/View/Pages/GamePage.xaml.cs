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

			foreach (Tile tile in GameModelGrid.Tiles)
			{
				GameGrid.Children.Add(CreateTile(tile.Value, tile.GetColor()), GameModelGrid.GetRow(), GameModelGrid.GetColumn())
			}
		}

		public StackLayout CreateTile (int value, Color color)
		{
			var RootEl = new StackLayout();

			var Background = new BoxView();

			Background.WidthRequest = 50;
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
			RootEl.Children.Add(label);

			return RootEl;
		}
	}
}
