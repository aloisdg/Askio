using System;

using Xamarin.Forms;

namespace Askio
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			this.Title = "Askio";
			this.BackgroundColor = Color.White;

			this.InitializeToolBarItems ();

			var listView = new ListView
			{
				RowHeight = 40
			};
			listView.ItemsSource = new string []
			{
				"Buy pears",
				"Buy oranges",
				"Buy mangos",
				"Buy apples",
				"Buy bananas"
			};
			listView.ItemSelected += async (sender, e) => {
				await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK");
				this.Navigation.PushAsync(new ChatPage());
			};
			this.Content = listView;
		}

		private void InitializeToolBarItems()
		{
			/*ToolbarItem _settings = new ToolbarItem ("Settings", "@drawable/settings", () => {
				DisplayAlert("Settings", "Settings here", "Ok");
			}, (ToolbarItemOrder)2);*/

			ToolbarItem _addRoom = new ToolbarItem ("Add room", "@drawable/add", () => {
				DisplayAlert("Add new room", "Add a new room here", "Create room");
			}, (ToolbarItemOrder)1);

			ToolbarItem _refresh = new ToolbarItem ("Refresh", "@drawable/refresh", () => {
				DisplayAlert("Refresh networks", "Refresh networks here", "Ok");
			}, (ToolbarItemOrder)0);

			//this.ToolbarItems.Add (_settings);
			this.ToolbarItems.Add (_addRoom);
			this.ToolbarItems.Add (_refresh);
		}
	}
}
