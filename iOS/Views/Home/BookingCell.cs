using System;
using System.Collections.Generic;
using Bookings.Core.Converters;
using Bookings.Core.Domain;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using ObjCRuntime;
using UIKit;

namespace Bookings.iOS.Views.Home
{
    public partial class BookingCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("BookingCell");
        public static readonly UINib Nib;

        static BookingCell()
        {
            Nib = UINib.FromName("BookingCell", NSBundle.MainBundle);
        }

        protected BookingCell(IntPtr handle) : base(handle)
        {
            InitialiseBindings();
        }

        List<Leg> _legs;
        public List<Leg> Legs { 
            get
            {
                return _legs;
            }
            set
            {
                _legs = value;
                if(stackLegs != null && _legs != null)
                {
                    ClearStackview();
                    AddToStackView(_legs);
                }
            }
        }

        public void AddToStackView(IEnumerable<Leg> legs)
        {
            foreach (var leg in legs)
            {
                var info = NSBundle.MainBundle.LoadNib("LegView", this, null);
                var v = Runtime.GetNSObject<LegView>(info.ValueAt(0));
                v.lblDepartureAirport.Text = leg.Origin;
                v.lblDepartureTime.Text = leg.Departure.ToString("HH:mm");
                v.lblArrivalAirport.Text = leg.Destination;
                v.lblArrivalTime.Text = leg.Arrival.ToString("HH:mm");
                stackLegs.AddArrangedSubview(v);
            }
        }

        public void ClearStackview()
        {
            var subviews = stackLegs.ArrangedSubviews;
            foreach (var item in subviews)
            {
                stackLegs.RemoveArrangedSubview(item);
                item.RemoveFromSuperview();
            }
        }

        private void InitialiseBindings()
        {
            this.DelayBind(() =>
            {
                this.SelectionStyle = UITableViewCellSelectionStyle.None;
                var set = this.CreateBindingSet<BookingCell, Booking>();
                set.Bind(lblPaxName).To(o => o.PaxName);
                set.Bind(lblActiveStatus).To(o => o.State).WithConversion<CapitalizeValueConverter>();
                set.Bind(lblConditions).To(o => o.Terms.Conditions).WithConversion<CapitalizeValueConverter>();
                set.Bind(this).For(v => v.Legs).To(o => o.Legs);
                set.Apply();
               
                stackLegs.Distribution = UIStackViewDistribution.EqualSpacing;
                stackLegs.Spacing = 4;
            });
        }
    }
}
