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
	partial class LegView
	{
		[Outlet]
		public UIKit.UILabel lblArrivalAirport { get; set; }

		[Outlet]
        public UIKit.UILabel lblArrivalTime { get; set; }

		[Outlet]
        public UIKit.UILabel lblDepartureAirport { get; set; }

		[Outlet]
        public UIKit.UILabel lblDepartureTime { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDepartureAirport != null) {
				lblDepartureAirport.Dispose ();
				lblDepartureAirport = null;
			}

			if (lblDepartureTime != null) {
				lblDepartureTime.Dispose ();
				lblDepartureTime = null;
			}

			if (lblArrivalAirport != null) {
				lblArrivalAirport.Dispose ();
				lblArrivalAirport = null;
			}

			if (lblArrivalTime != null) {
				lblArrivalTime.Dispose ();
				lblArrivalTime = null;
			}
		}
	}
}
