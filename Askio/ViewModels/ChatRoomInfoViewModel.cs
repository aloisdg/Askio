using System;
using System.Collections.ObjectModel;

namespace Askio
{
	public class ChatRoomInfoViewModel
	{
		public ObservableCollection<ChatRoomInfo> ChatRoomInformations { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Askio.ChatRoomInfoViewModel"/> class.
		/// </summary>
		public ChatRoomInfoViewModel ()
		{
			this.ChatRoomInformations = new ObservableCollection<ChatRoomInfo> ();

			this.ChatRoomInformations.Add (new ChatRoomInfo () {
				Name = "What's up?",
				CreatorName = "Filipe",
				Image = null
			});
		}

		/// <summary>
		/// Adds the new chat room.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="creatorName">Creator name.</param>
		/// <param name="imageUri">Image URI.</param>
		public void AddNewChatRoom(String name, String creatorName, String imageUri)
		{
			this.ChatRoomInformations.Add (new ChatRoomInfo () {
				Name = name,
				CreatorName = creatorName,
				Image = imageUri
			});
		}

		/// <summary>
		/// Removes the chat room.
		/// </summary>
		/// <param name="roomInfo">Room info.</param>
		public void RemoveChatRoom(ChatRoomInfo roomInfo)
		{
			this.ChatRoomInformations.Remove (roomInfo);
		}

		/// <summary>
		/// Removes the name of the chat room by creator.
		/// </summary>
		/// <param name="creatorName">Creator name.</param>
		public void RemoveChatRoomByCreatorName(String creatorName)
		{
			Int32 _index = 0;

			for (; _index < this.ChatRoomInformations.Count; ++_index) {
				if (this.ChatRoomInformations [_index].CreatorName == creatorName) {
					break;
				}
			}
			this.ChatRoomInformations.RemoveAt (_index);
		}
	}
}

