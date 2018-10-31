using Xamarin.Forms;

namespace TWON
{
	class Tile
	{
		public int Value { get; set; }

		// NOTE: These may not be needed at all!
		public int X { get; set; }
		public int Y { get; set; }

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
