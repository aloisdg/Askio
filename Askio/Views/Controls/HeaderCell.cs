using Xamarin.Forms;

namespace Askio
{
	/// <summary>
	/// Header cell.
	/// </summary>
	public class HeaderCell : ViewCell
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Askio.HeaderCell"/> class.
		/// </summary>
		public HeaderCell()
		{
			this.Height = 25;
			var title = new Label
			{
				Font = Font.SystemFontOfSize(NamedSize.Small, FontAttributes.Bold),
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Center
			};

			title.SetBinding(Label.TextProperty, "Key");

			View = new StackLayout
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 25,
				BackgroundColor = Color.FromRgb(52, 152, 218),
				Padding = 5,
				Orientation = StackOrientation.Horizontal,
				Children = { title }
			};
		}
	}
}

