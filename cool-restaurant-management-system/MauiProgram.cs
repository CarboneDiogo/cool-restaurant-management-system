﻿using Blazorise;
using Blazorise.Bootstrap;

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
        builder.Services.AddBlazorise(options => { options.Immediate = true; }).AddBootstrapProviders();
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "restaurant.db");

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif


        return builder.Build();
    }
}
