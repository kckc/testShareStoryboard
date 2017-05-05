// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace test
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		UIKit.UITextField FirstText { get; set; }

		[Action ("DifferentProjectButtonAction:")]
		partial void DifferentProjectButtonAction (Foundation.NSObject sender);

		[Action ("SameProjectButtonActoin:")]
		partial void SameProjectButtonActoin (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstText != null) {
				FirstText.Dispose ();
				FirstText = null;
			}
		}
	}
}
