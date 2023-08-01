using Microsoft.AspNetCore.Components.WebView.Maui;
using cool_restaurant_management_system.Data;

namespace cool_restaurant_management_system;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Regular.ttf", "montserrat");
                fonts.AddFont("Montserrat-Light", "montserrat-light");
                fonts.AddFont("Montserrat-Bold.ttf", "montserrat-bold");
            });

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		

		return builder.Build();
	}
}
