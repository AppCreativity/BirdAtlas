using System;
using BirdAtlasMaui.ViewModels;
using BirdAtlasMaui.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace BirdAtlasMaui
{
	public partial class App : Application
	{
		public App(IServiceProvider serviceProvider)
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage(serviceProvider.GetRequiredService<MainViewModel>()));
		}
	}
}
