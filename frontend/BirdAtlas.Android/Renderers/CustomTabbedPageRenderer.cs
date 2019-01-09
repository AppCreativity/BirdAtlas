using System;
using System.ComponentModel;
using Android.Content;
using Android.Support.Design.Widget;
using Android.Views;
using BirdAtlas.Controls;
using BirdAtlas.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace BirdAtlas.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals(CustomTabbedPage.IsHiddenProperty.PropertyName))
            {
                TabLayout TabsLayout = null;
                for (int i = 0; i < ChildCount; ++i)
                {
                    Android.Views.View view = (Android.Views.View)GetChildAt(i);
                    if (view is TabLayout)
                        TabsLayout = (TabLayout)view;
                }

                if (Element is CustomTabbedPage customTabbed)
                {
                    TabsLayout.Visibility = customTabbed.IsHidden ? ViewStates.Invisible : ViewStates.Visible;
                }
            }
        }
    }
}