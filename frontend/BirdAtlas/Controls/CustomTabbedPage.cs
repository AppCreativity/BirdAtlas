using System;
using BirdAtlas.Models;
using Xamarin.Forms;

namespace BirdAtlas.Controls
{
    public class CustomTabbedPage : TabbedPage
    {
        public static readonly BindableProperty IsHiddenProperty =
            BindableProperty.Create(nameof(IsHidden), typeof(bool), typeof(CustomTabbedPage), false);

        public static readonly BindableProperty PageTabModeProperty =
            BindableProperty.Create(nameof(PageTabMode), typeof(PageTabMode), typeof(CustomTabbedPage), PageTabMode.None);

        public bool IsHidden
        {
            get => (bool)GetValue(IsHiddenProperty);
            set => SetValue(IsHiddenProperty, value);
        }

        public PageTabMode PageTabMode
        {
            get => (PageTabMode)GetValue(PageTabModeProperty);
            set => SetValue(PageTabModeProperty, value);
        }
    }
}