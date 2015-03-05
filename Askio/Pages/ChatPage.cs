using System;

using Xamarin.Forms;

namespace Askio
{
	public class ChatPage : ContentPage
	{
		public ChatPage ()
		{
			this.Title = "Chat room";
			this.BackgroundColor = Color.White;

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


