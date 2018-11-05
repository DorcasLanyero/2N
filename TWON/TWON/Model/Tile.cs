using Xamarin.Forms;

namespace TWON
{
	public class Tile
	{
		public int Value { get; set; }
		
		public Color GetColor()
		{
			switch (Value)
			{
				// TODO: Get other colors for Value's value
				default:
					return Color.Maroon;
			}
		}
	}
}
