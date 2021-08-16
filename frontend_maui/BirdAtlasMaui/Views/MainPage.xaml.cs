using Microsoft.Maui.Controls;
using BirdAtlasMaui.ViewModels;

namespace BirdAtlasMaui.Views
{
    public partial class MainPage : ContentPage
	{
		MainViewModel _mainViewModel;

		public MainPage(MainViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = _mainViewModel = viewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

			await _mainViewModel.Load();
        }
    }
}