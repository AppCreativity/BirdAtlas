using System;
using BirdAtlas.Controls;
using BirdAtlas.iOS.Framework;
using BirdAtlas.iOS.Renderers;
using BirdAtlas.Views;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace BirdAtlas.iOS.Renderers
{
    public class CustomTabbedPageRenderer : TabbedRenderer
    {
        private UIView _overlayTabView;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            Element.PropertyChanged += OnElementPropertyChanged;

            var rect = new CGRect(0, 0, 250, 55);
            _overlayTabView = Helpers.ConvertFormsToNative(new OverlayTabView(), rect);

            var result = UIScreen.MainScreen.Bounds;
            var x = (result.Width / 2) - 125;
            var y = (result.Height - (55 + 20));

            _overlayTabView.Frame = new CGRect(x, y, 250, 55);
        }

        private void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (Element is CustomTabbedPage customTabbed)
            {
                if (e.PropertyName.Equals(CustomTabbedPage.IsHiddenProperty.PropertyName))
                    TabBar.Hidden = customTabbed.IsHidden;

                if (e.PropertyName.Equals(CustomTabbedPage.PageTabModeProperty.PropertyName))
                {
                    switch(customTabbed.PageTabMode)
                    {
                        case Models.PageTabMode.Floating:
                            View.AddSubview(_overlayTabView);
                            break;
                        case Models.PageTabMode.None:
                            _overlayTabView.RemoveFromSuperview();
                            break;
                    }
                }
            }
        }
    }
}