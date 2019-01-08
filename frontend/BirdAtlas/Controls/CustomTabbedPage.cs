using System;
using Xamarin.Forms;

namespace BirdAtlas.Controls
{
    public class CustomTabbedPage : TabbedPage
    {
        public static readonly BindableProperty IsHiddenProperty = BindableProperty.Create(nameof(IsHidden), typeof(bool), typeof(CustomTabbedPage), false);

        public bool IsHidden
        {
            get => (bool)GetValue(IsHiddenProperty);
            set => SetValue(IsHiddenProperty, value);
        }
    }
}