using Microsoft.Maui.Controls;
using BirdAtlasMaui.ViewModels;

namespace BirdAtlasMaui.Views
{
    public partial class StoriesPage : ContentPage
	{
		StoriesViewModel _storiesViewModel;

		public StoriesPage(StoriesViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = _storiesViewModel = viewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			await _storiesViewModel.Load();
        }
    }
}