using System;
using BirdAtlas.Controls;
using BirdAtlas.iOS.Renderers;
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