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
		private IServiceProvider _serviceProvider;

		public App(IServiceProvider serviceProvider)
		{
			InitializeComponent();

			_serviceProvider = serviceProvider;
			MainPage = new MainPage(_serviceProvider.GetRequiredService<MainViewModel>());
		}
	}
}