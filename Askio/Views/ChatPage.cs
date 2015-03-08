using System;

using Xamarin.Forms;

namespace Askio
{
	public class ChatPage : ContentPage
	{
		private ChatPageViewModel chatPageViewModel;

		private Button sendButton;
		private Entry messageInput;
		private ChatListView messageList;

		public ChatPage (String pageName)
		{
			this.Title = pageName;
			this.chatPageViewModel = new ChatPageViewModel ();

			this.sendButton = new Button ();
			this.sendButton.Text = " Send ";
			this.sendButton.VerticalOptions = LayoutOptions.EndAndExpand;
			this.sendButton.Clicked += (object sender, EventArgs e) => {
				this.chatPageViewModel.AddMessage ("AddMessage() ok!", "User");
			};

			if (Device.OS == TargetPlatform.WinPhone) {
				this.sendButton.BackgroundColor = Color.Green;
				this.sendButton.BorderColor = Color.Green;
				this.sendButton.TextColor = Color.White; 
			}

			this.messageInput = new Entry ();
			this.messageInput.HorizontalOptions = LayoutOptions.FillAndExpand;
			this.messageInput.Keyboard = Keyboard.Chat;
			this.messageInput.Placeholder = "Type a message...";
			this.messageInput.HeightRequest = 30;

			this.messageList = new ChatListView ();
			this.messageList.VerticalOptions = LayoutOptions.FillAndExpand;
			this.messageList.ItemTemplate = new DataTemplate (CreateMessageCell);
			this.messageList.ItemsSource = this.chatPageViewModel.Messages;

			this.Content = new StackLayout {
				Padding = Device.OnPlatform (new Thickness (6, 6, 6, 6), new Thickness (0), new Thickness (0)),
				Children = {
					new StackLayout {
						Children = { this.messageInput, this.sendButton },
						Orientation = StackOrientation.Horizontal,
						Padding = new Thickness (0, Device.OnPlatform (0, 20, 0), 0, 0),
					},
					this.messageList,
				}
			};
		}

		private Cell CreateMessageCell()
		{
			Label _timestampLabel = new Label();
			_timestampLabel.SetBinding(Label.TextProperty, new Binding("Timestamp", stringFormat: "[{0:HH:mm}]"));
			_timestampLabel.TextColor = Color.Silver;

			Label _authorLabel = new Label();
			_authorLabel.SetBinding(Label.TextProperty, new Binding("AuthorName", stringFormat: "{0}: "));
			_authorLabel.TextColor = Device.OnPlatform(Color.Blue, Color.Yellow, Color.Yellow);

			Label _messageLabel = new Label();
			_messageLabel.SetBinding(Label.TextProperty, new Binding("Text"));

			StackLayout _stack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children = {_authorLabel, _messageLabel}
			};

			if (Device.Idiom == TargetIdiom.Tablet)
			{
				_stack.Children.Insert(0, _timestampLabel);
			}

			MessageViewCell view = new MessageViewCell
			{
				View = _stack
			};
			return view;
		}

	}
}


