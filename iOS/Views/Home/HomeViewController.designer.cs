// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Bookings.iOS.Views
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UITableView tblBookings { get; set; }

		[Outlet]
		UIKit.UIView vStroke { get; set; }

		[Outlet]
		UIKit.UIView vTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tblBookings != null) {
				tblBookings.Dispose ();
				tblBookings = null;
			}

			if (vTitle != null) {
				vTitle.Dispose ();
				vTitle = null;
			}

			if (vStroke != null) {
				vStroke.Dispose ();
				vStroke = null;
			}
		}
	}
}
