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
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            Element.PropertyChanged += OnElementPropertyChanged;

            var rect = new CGRect(0, 0, 250, 55);
            var overlayTabView = Helpers.ConvertFormsToNative(new OverlayTabView(), rect);

            var result = UIScreen.MainScreen.Bounds;
            var x = (result.Width / 2) - 125;
            var y = (result.Height - (55 + 20));

            overlayTabView.Frame = new CGRect(x, y, 250, 55);

            View.AddSubview(overlayTabView);
        }

        private void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals(CustomTabbedPage.IsHiddenProperty.PropertyName))
            {
                if(Element is CustomTabbedPage customTabbed)
                {
                    TabBar.Hidden = customTabbed.IsHidden;
                }
            }
        }
    }
}