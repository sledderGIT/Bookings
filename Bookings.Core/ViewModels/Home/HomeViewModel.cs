using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookings.Core.Services;
using System.Linq;
using Acr.UserDialogs;
using Bookings.Core.Filters;

namespace Bookings.Core.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        private readonly IBookingService _bookingService;

        public HomeViewModel(IBookingService bookingService, IUserDialogs userDialog): base(userDialog)
        {
            this._bookingService = bookingService;
        }

        public override Task Initialize()
        {
            LoadBookings();
            return base.Initialize();
        }

        public async Task LoadBookings()
        {
            try
            {
                IsLoading = true;
                GroupedList = BookingFilter.GroupBookings(await _bookingService.GetBookings()).ToList();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private List<BookingGroup> _groupedList;
        public List<BookingGroup> GroupedList
        {
            get { return _groupedList; }
            set {
                SetProperty(ref _groupedList, value);
            }
        }
    }
}
