using System;
using Acr.UserDialogs;
using Bookings.Core.AutoMapper;
using Bookings.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Bookings.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            AutomapperInitializer.Initialize();
            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
        }
    }
}
