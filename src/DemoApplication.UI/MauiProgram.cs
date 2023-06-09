﻿using DemoApplication.UI.Components.Data;
using Microsoft.Extensions.Logging;

namespace DemoApplication.UI
{
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            //This is coming in from the service
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}