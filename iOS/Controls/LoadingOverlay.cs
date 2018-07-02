using Bookings.iOS;
using CoreGraphics;
using UIKit;

namespace Common.iOS
{
	public class LoadingOverlay : UIView
	{
		public UIProgressView ProgressBar { get; set; }

		public UIActivityIndicatorView ActivitySpinner { get; set; }

		public UIButton RetryButton { get; set; }

		public bool HideActivitySpinner
		{
			get { return false; }
			set
			{
				if (value)
				{
					ActivitySpinner.StopAnimating();
				}
				else
				{
					ActivitySpinner.StartAnimating();
				}
			}
		}

		public LoadingOverlay(CGRect rect) : base(rect)
		{
			//_loadingOverlay = new UIView (new RectangleF(0,0, View.Bounds.Width, View.Bounds.Height));
            BackgroundColor = Constants.Colors.OverlayColor;
			AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
			ActivitySpinner = new UIActivityIndicatorView(new CGRect((rect.Width - 37) / 2, (rect.Height - 37) / 2, 37, 37));
			ActivitySpinner.HidesWhenStopped = true;
			ActivitySpinner.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.WhiteLarge;
            ActivitySpinner.Color = Constants.Colors.LightBlue;
			ActivitySpinner.StartAnimating();
			ActivitySpinner.AutoresizingMask = UIViewAutoresizing.FlexibleMargins;
			Add(ActivitySpinner);
		}
	}
}

