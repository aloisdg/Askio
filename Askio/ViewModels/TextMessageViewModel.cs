using System;

namespace Askio
{
	public class TextMessageViewModel
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id { get; private set; }

		/// <summary>
		/// Gets the name of the author.
		/// </summary>
		/// <value>The name of the author.</value>
		public string AuthorName { get; private set; }

		/// <summary>
		/// Gets the text.
		/// </summary>
		/// <value>The text.</value>
		public string Text { get; private set; }

		/// <summary>
		/// Gets the timestamp.
		/// </summary>
		/// <value>The timestamp.</value>
		public DateTime Timestamp { get; private set; }

		/// <summary>
		/// Gets a value indicating whether this instance is mine.
		/// </summary>
		/// <value><c>true</c> if this instance is mine; otherwise, <c>false</c>.</value>
		public Boolean IsMine { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Askio.TextMessageViewModel"/> class.
		/// </summary>
		/// <param name="message">Message.</param>
		/// <param name="currentAuthorName">Current author name.</param>
		public TextMessageViewModel (TextMessage message, String currentAuthorName)
		{
			this.Id = message.Id;
			this.AuthorName = message.AuthorName;
			this.Text = message.Text;
			this.Timestamp = message.Timestamp;
			this.IsMine = currentAuthorName == this.AuthorName;
		}
	}
}

