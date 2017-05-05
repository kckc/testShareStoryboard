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
	[Register ("SameProjSBViewController")]
	partial class SameProjSBViewController
	{
		[Outlet]
		UIKit.UITextField SecondText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SecondText != null) {
				SecondText.Dispose ();
				SecondText = null;
			}
		}
	}
}
