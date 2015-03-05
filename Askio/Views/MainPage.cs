using System;

using Xamarin.Forms;

namespace Askio
{
	public class MainPage : ContentPage
	{
		private ChatRoomInfoViewModel chatRoomViewModel;
		private ListView listView;

		/// <summary>
		/// Initializes a new instance of the <see cref="Askio.MainPage"/> class.
		/// </summary>
		public MainPage ()
		{
			this.Title = "Askio";
			this.BackgroundColor = Color.White;

			this.chatRoomViewModel = new ChatRoomInfoViewModel ();

			this.InitializeToolBarItems ();
			this.InitializeListView ();

			this.Content = this.listView;
		}

		/// <summary>
		/// Initializes the tool bar items.
		/// </summary>
		private void InitializeToolBarItems()
		{
			ToolbarItem _addRoom = new ToolbarItem ("Add room", "@drawable/add", () => {
				DisplayAlert("Add new room", "Add a new room here", "Create room");
			}, (ToolbarItemOrder)1);

			ToolbarItem _refresh = new ToolbarItem ("Refresh", "@drawable/refresh", () => {
				DisplayAlert("Refresh networks", "Refresh networks here", "Ok");
			}, (ToolbarItemOrder)0);

			this.ToolbarItems.Add (_addRoom);
			this.ToolbarItems.Add (_refresh);
		}

		/// <summary>
		/// Initializes the list view.
		/// </summary>
		private void InitializeListView()
		{
			this.listView = new ListView();

			this.listView.ItemsSource = this.chatRoomViewModel.ChatRoomInformations;
			this.listView.HasUnevenRows = true;
			if(Device.OS != TargetPlatform.WinPhone)
				this.listView.GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell));

			// Cell definition
			DataTemplate cell = new DataTemplate(typeof(AspectImageCell));
			cell.SetBinding(TextCell.TextProperty, "Name");
			cell.SetBinding(TextCell.DetailProperty, "CreatorName");
			cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
			this.listView.ItemTemplate = cell;

			// List events

			this.listView.ItemTapped += (sender, e) => {
				this.Navigation.PushAsync(new ChatPage());
				this.listView.SelectedItem = null;
			};
		}
	}

	public class AspectImageCell : ImageCell { }
}
