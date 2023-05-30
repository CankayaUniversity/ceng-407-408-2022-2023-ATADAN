﻿using Microsoft.Extensions.Logging;
using Atadan.Data;

using Maui.GoogleMaps.Hosting;

namespace Atadan;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            //#if IOS
            //			.UseGoogleMaps("")
            //#elif ANDROID
            //			.UseGoogleMaps()
            //#endif
            .UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
