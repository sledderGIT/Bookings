// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Bookings.iOS
{
	partial class GroupHeader
	{
		[Outlet]
		public UIKit.UILabel lblAirport { get; set; }

		[Outlet]
		public UIKit.UILabel lblDate { get; set; }

		[Outlet]
		public UIKit.UILabel lblTitle { get; private set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTitle != null) {
				lblTitle.Dispose ();
				lblTitle = null;
			}

			if (lblDate != null) {
				lblDate.Dispose ();
				lblDate = null;
			}

			if (lblAirport != null) {
				lblAirport.Dispose ();
				lblAirport = null;
			}
		}
	}
}
