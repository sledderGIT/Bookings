using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Bookings.iOS
{
    [Register("GroupHeader")]
    public partial class GroupHeader: UITableViewHeaderFooterView
    {
        
        public GroupHeader(CGRect frame): base(frame)
        {
        }

        public GroupHeader(IntPtr ptr): base(ptr)
        {

        }

        public GroupHeader(NSString identifier): base(identifier)
        {

        }

        public GroupHeader()
        {

        }

        public GroupHeader(NSCoder coder): base(coder)
        {

        }
    }
}
