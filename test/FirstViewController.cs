using System;

using UIKit;

namespace test
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			// Perform any additional setup after loading the view, typically from a nib.

			//var appDelegate = (UIApplicationDelegate)UIApplication.SharedApplication.Delegate;
			//appDelegate.Window.RootViewController = ctlr;
		}

		partial void SameProjectButtonActoin(Foundation.NSObject sender)
		{
			var sb = UIStoryboard.FromName("SecondStoryboard", null);
			var ctlr = sb.InstantiateInitialViewController();

			this.PresentViewController(ctlr, true, null);

		}

		partial void DifferentProjectButtonAction(Foundation.NSObject sender)
		{

			var sb = UIStoryboard.FromName("Storyboard", null);
			var ctlr = sb.InstantiateInitialViewController();

			this.PresentViewController(ctlr, true, null);

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

