using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using BirdAtlasMaui.API.Services;
using Microsoft.Extensions.DependencyInjection;
using BirdAtlasMaui.ViewModels;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace BirdAtlasMaui
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.UseMauiServiceProviderFactory(constructorInjection: true)
				.ConfigureServices(services =>
				{
					services.AddSingleton<IStoryApi, StoryService>();
					services.AddSingleton<IHabitatApi, HabitatService>();
					services.AddSingleton<IBirdApi, BirdService>();
					services.AddTransient<MainViewModel>();
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
		}
	}
}