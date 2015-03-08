using System;
using System.Collections.ObjectModel;

namespace Askio
{
	public class ChatPageViewModel
	{
		public ObservableCollection<TextMessageViewModel> Messages { get; private set; }

		public ChatPageViewModel ()
		{
			this.Messages = new ObservableCollection<TextMessageViewModel> ();
		}

		public void AddMessage(String text, String author)
		{
			TextMessage _message = new TextMessage ();
			_message.AuthorName = author;
			_message.Text = text;
			_message.Timestamp = DateTime.Now;

			this.Messages.Add (new TextMessageViewModel (_message, author));
		}
	}
}

