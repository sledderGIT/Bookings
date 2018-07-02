using System;
using Foundation;
using UIKit;
using CoreGraphics;
using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using System.Linq;
using ObjCRuntime;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;

namespace Common.iOS
{
    public class BaseViewController<TViewModel> : MvxViewController<TViewModel> where TViewModel: class, IMvxViewModel
	{
		LoadingOverlay _loadingOverlay;


		public BaseViewController()
		{
			
		}

		public BaseViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
		{
			
		}

		public virtual void ShowLoadingOverlay()
		{
			if (_loadingOverlay == null)
				_loadingOverlay = new LoadingOverlay(new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
			Add(_loadingOverlay);
		}

		public virtual void HideLoadingOverlay()
		{
			if (_loadingOverlay != null)
				_loadingOverlay.RemoveFromSuperview();
		}

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
				SetIsLoading(value);
			}
		}

		public virtual void SetIsLoading(bool value)
		{
			if (value)
			{
				ShowLoadingOverlay();
			}
			else
			{
				HideLoadingOverlay();
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var bindingDictionary = new Dictionary<object, string>();
			bindingDictionary[this] = @"IsLoading IsLoading";
			this.AddBindings(bindingDictionary);
		}
	}
}
