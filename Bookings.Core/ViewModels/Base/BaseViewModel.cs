using System;
using Acr.UserDialogs;
using MvvmCross.ViewModels;

namespace Bookings.Core.ViewModels
{
    public class BaseViewModel: MvxViewModel
    {
        public IUserDialogs UserDialogs { get; set; }

        public BaseViewModel(IUserDialogs userDialogs)
        {
            UserDialogs = userDialogs;
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                SetProperty(ref _isLoading, value);
            }
        }

        public virtual void ShowError(Exception ex)
        {
            //some error message logic should be implemented here
            UserDialogs.Alert("Something went wrong");
        }
    }
}
