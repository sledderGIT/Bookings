using System;
using Bookings.Core.ViewModels;
using Common.iOS;
using CoreAnimation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace Bookings.iOS.Views
{
    public partial class HomeViewController : BaseViewController<HomeViewModel>
    {
        public HomeViewController() : base("HomeViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InitializeUI();
            ConfigureTableView();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.NavigationController.SetNavigationBarHidden(true, false);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            this.NavigationController.SetNavigationBarHidden(false, true);
        }

        public void ConfigureTableView()
        {
            tblBookings.SectionFooterHeight = 0;
            var source = new BookingGroupTableSource(tblBookings);
            tblBookings.Source = source;
            tblBookings.ReloadData();
            var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();
            set.Bind(source).For(v => v.ItemsSource).To(vm => vm.GroupedList);
            set.Apply();
        }

        public void InitializeUI()
        {
            this.View.BackgroundColor = Constants.Colors.LightGray;
            vTitle.BackgroundColor = Constants.Colors.LightGray;
            vStroke.BackgroundColor = Constants.Colors.StrokeColor;
        }
    }
}

