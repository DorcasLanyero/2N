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

			for (int i=0; i<4;i++)
			{
				for (int j=0;j<4;j++)
				{
					var RootEl = new StackLayout();
					var Background = new Image();

					Background.Source = "tile.png";
					Background.WidthRequest = 50;


					var label = new Label {
						Text = Convert.ToString(i),
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						FontSize = 20,
						TranslationY = -45
					};



					RootEl.Children.Add(Background);
					RootEl.Children.Add(label);

					GameGrid.Children.Add(RootEl, i, j);
				}
			}
		}
	}
}
