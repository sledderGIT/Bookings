using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Bookings.Core.Services;
using CoreGraphics;
using Foundation;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;

namespace Bookings.iOS
{
    public class BookingGroupTableSource: MvxBaseTableViewSource
    {
        private static readonly NSString BookingCellIdentifier = new NSString("BookingCell");
        private static readonly NSString GroupHeaderIdentifier = new NSString("GroupHeader");

        public BookingGroupTableSource(UITableView tableView)
            : base(tableView)
        {
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            tableView.RegisterNibForCellReuse(UINib.FromName("BookingCell", NSBundle.MainBundle),
                                              BookingCellIdentifier);
            tableView.RegisterNibForHeaderFooterViewReuse(UINib.FromName("GroupHeader", NSBundle.MainBundle),
                                                          GroupHeaderIdentifier);
            
        }

        private IList<BookingGroup> _bookingGroups;
        public IList<BookingGroup> ItemsSource
        {
            get
            {
                return _bookingGroups;

            }
            set
            {
                _bookingGroups = value;
                ReloadTableData();
            }
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            return TableView.DequeueReusableCell(BookingCellIdentifier, indexPath);
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            if (_bookingGroups == null)
                return null;

            return _bookingGroups[(int)section].Key.ToString();
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return 44f;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            if (_bookingGroups == null)
                return null;
            var sectionHeaderView = tableView.DequeueReusableHeaderFooterView(GroupHeaderIdentifier) as GroupHeader;
            sectionHeaderView.lblTitle.Text = _bookingGroups[(int)section].Key.VesselName;
            sectionHeaderView.lblAirport.Text = _bookingGroups[(int)section].Key.CrewChangeAirport;
            sectionHeaderView.lblDate.Text = _bookingGroups[(int)section].Key.CrewChangeDate.ToString("dd/MM");
            return sectionHeaderView;
        }

        protected override object GetItemAt(NSIndexPath indexPath)
        {
            if (_bookingGroups == null)
                return null;

            return _bookingGroups[indexPath.Section][indexPath.Row];
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 53 + 24; // (_bookingGroups != null? 
                        // _bookingGroups[indexPath.Section][indexPath.Row].Legs.Count * 40 : 0);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView(new CGRect(0,0,0,0));
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            if (_bookingGroups == null)
                return 0;

            return _bookingGroups.Count;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            if (_bookingGroups == null)
                return 0;
            
            return _bookingGroups[(int)section].Count;
        }
    }
}
