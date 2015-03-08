using System;

namespace Askio
{
	/// <summary>
	/// Text message.
	/// </summary>
	public class TextMessage
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the author.
		/// </summary>
		/// <value>The name of the author.</value>
		public string AuthorName { get; set; }

		/// <summary>
		/// Gets or sets the body of the message.
		/// </summary>
		/// <value>The body.</value>
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the timestamp.
		/// </summary>
		/// <value>The timestamp.</value>
		public DateTime Timestamp { get; set; }
	}
}

