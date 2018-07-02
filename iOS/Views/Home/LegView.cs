using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Bookings.iOS.Views.Home
{
    [Register("LegView")]
    public partial class LegView: UIView
    {
        public LegView(CGRect frame) : base(frame)
        {
        }

        public LegView(IntPtr ptr) : base(ptr)
        {

        }

        public LegView()
        {

        }

        public LegView(NSCoder coder) : base(coder)
        {

        }
    }
}
