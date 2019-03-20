using System;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace BirdAtlas.Droid.Framework
{
    public static class Helpers
    {
        public static Android.Views.View ConvertFormsToNative(Xamarin.Forms.View view, Context context, Rectangle size)
        {
            //var renderer = Platform.CreateRendererWithContext(view, Android.App.Application.Context);
            var renderer = Platform.CreateRendererWithContext(view, context);

            var nativeView = renderer.View;

            renderer.Tracker.UpdateLayout();
            var layoutParams = new ViewGroup.LayoutParams((int)size.Width, (int)size.Height);
            nativeView.LayoutParameters = layoutParams;
            view.Layout(size);
            nativeView.Layout(0, 0, (int)view.WidthRequest, (int)view.HeightRequest);

            return nativeView;
        }
    }
}