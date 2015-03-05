using System;

using Xamarin.Forms;

namespace Askio
{
	public class App : Application
	{
		public App ()
		{
			this.MainPage = new NavigationPage (new Askio.MainPage ()) {
				BarBackgroundColor = Color.FromRgb(0x00, 0xab, 0xa9)
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

