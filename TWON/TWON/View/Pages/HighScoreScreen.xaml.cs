using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TWON.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HighScoreScreen : ContentPage
	{
		public HighScoreScreen ()
		{
			InitializeComponent ();
		}

		public void Generate_HighScoreScreen(List<string> HighScoreData)
		{
				
		}
	}
}
