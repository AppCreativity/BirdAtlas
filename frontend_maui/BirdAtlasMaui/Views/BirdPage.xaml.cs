using Microsoft.Maui.Controls;
using BirdAtlasMaui.ViewModels;

namespace BirdAtlasMaui.Views
{
    public partial class BirdPage : ContentPage
	{
		BirdViewModel _birdViewModel;

		public BirdPage(BirdViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = _birdViewModel = viewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			await _birdViewModel.Load();
        }
    }
}