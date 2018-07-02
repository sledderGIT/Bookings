// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Bookings.iOS.Views.Home
{
	[Register ("BookingCell")]
	partial class BookingCell
	{
		[Outlet]
		UIKit.UILabel lblActiveStatus { get; set; }

		[Outlet]
		UIKit.UILabel lblConditions { get; set; }

		[Outlet]
		UIKit.UILabel lblPaxName { get; set; }

		[Outlet]
		UIKit.UIStackView stackLegs { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblActiveStatus != null) {
				lblActiveStatus.Dispose ();
				lblActiveStatus = null;
			}

			if (lblConditions != null) {
				lblConditions.Dispose ();
				lblConditions = null;
			}

			if (lblPaxName != null) {
				lblPaxName.Dispose ();
				lblPaxName = null;
			}

			if (stackLegs != null) {
				stackLegs.Dispose ();
				stackLegs = null;
			}
		}
	}
}
