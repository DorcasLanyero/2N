using Xamarin.Forms;

namespace TWON
{
	public class Tile
	{
		public int Value { get; set; }

		public Tile()
		{
			Value = 2;
		}

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
