using F1Stats.ViewModels;
using F1Stats.Views;

namespace F1Stats;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<SingletonPage>();
        builder.Services.AddSingleton<SingletonPageViewModel>();

        return builder.Build();
	}
}
