using System.ComponentModel;
using System.Net;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Askio;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;
using Askio.Droid;

[assembly: ExportRenderer(typeof(MessageViewCell), typeof(MessageRenderer))]

namespace Askio.Droid
{
	/// <summary>
	/// Custom Message renderer for Android.
	/// </summary>
	public class MessageRenderer : ViewCellRenderer
	{
		/// <summary>
		/// Gets the cell core.
		/// </summary>
		/// <returns>The cell core.</returns>
		/// <param name="item">Item.</param>
		/// <param name="convertView">Convert view.</param>
		/// <param name="parent">Parent.</param>
		/// <param name="context">Context.</param>
		protected override View GetCellCore(Cell item, View convertView, ViewGroup parent, Context context)
		{
			var inflatorservice = (LayoutInflater)Forms.Context.GetSystemService (Android.Content.Context.LayoutInflaterService);
			var textMsgVm = item.BindingContext as TextMessageViewModel;

			if (textMsgVm != null) {
				var template = (LinearLayout)inflatorservice.Inflate (textMsgVm.IsMine ? Resource.Layout.MessageItemOwner : Resource.Layout.MessageItemOpponent, null, false);
				//template.FindViewById<TextView>(Resource.Id.timestamp).Text = textMsgVm.Timestamp.ToString("HH:mm");
				template.FindViewById<TextView> (Resource.Id.nick).Text = textMsgVm.IsMine ? "Me:" : textMsgVm.AuthorName + ":";
				template.FindViewById<TextView> (Resource.Id.message).Text = textMsgVm.Text;

				return template;
			}

			return base.GetCellCore (item, convertView, parent, context);
		}

		/// <summary>
		/// Raises the cell property changed event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnCellPropertyChanged(sender, e);
		}
	}
}

