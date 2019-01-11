using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    public static class Extensions
    {
        public static List<Android.Views.View> GetViewsByType(this Android.Views.View view, Type viewType = null)
        {
            if (!(view is ViewGroup group))
                return new List<Android.Views.View>();

            var result = new List<Android.Views.View>();

            for (int i = 0; i < group.ChildCount; i++)
            {
                var child = group.GetChildAt(i);
                result.AddRange(child.GetViewsByType(viewType));

                if (viewType == null || child.GetType() == viewType)
                    result.Add(child);
            }

            return result.Distinct().ToList();
        }

        public static void FindAndRemoveById(this Android.Views.View view, int id)
        {
            var childView = view.FindViewById(id);
            ((ViewGroup)childView.Parent).RemoveView(childView);
        }
    }

    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals(CustomTabbedPage.IsHiddenProperty.PropertyName) && Element is CustomTabbedPage customTabbed)
            {
                var views = ViewGroup.GetViewsByType(typeof(BottomNavigationView));
                if(views != null && views.Any())
                {
                    var bottomView = views.FirstOrDefault() as BottomNavigationView;
                    //bottomView.Visibility = customTabbed.IsHidden ? ViewStates.Invisible : ViewStates.Visible;
                    //bottomView.TranslationY = customTabbed.IsHidden ? bottomView.TranslationY + bottomView.Height : bottomView.TranslationY - bottomView.Height;

                    //TODO: Glenn - Hmm hiding bottom tabbar leaves empty space in Android
                    if(customTabbed.IsHidden)
                        bottomView.Animate().TranslationY(bottomView.Height);
                    else
                        bottomView.Animate().TranslationY(0);
                }
            }
        }
    }
}