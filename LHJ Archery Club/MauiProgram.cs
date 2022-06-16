using Microsoft.AspNetCore.Components.WebView.Maui;
using LHJ_Archery_Club.Data;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Radzen;
using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using Majorsoft.Blazor.WebAssembly.Logging.Console;

namespace LHJ_Archery_Club;

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
#endif

        // Blazorize
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services
            .AddBlazorise(options =>
            {
                options.Immediate = true;
            })
            .AddBootstrapProviders()
            .AddFontAwesomeIcons();

        // Radzen
        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddScoped<TooltipService>();
        builder.Services.AddScoped<ContextMenuService>();
        builder.Services.AddBlazoredLocalStorage();

        //// Logger
        //builder.Services.AddLogging(builder => builder
        //    .AddBrowserConsole()
        //    .SetMinimumLevel(LogLevel.Trace)
        //);
        //builder.Logging.SetMinimumLevel(LogLevel.Warning);

        builder.Logging.AddBrowserConsole()
            .SetMinimumLevel(LogLevel.Debug) //Setting LogLevel is optional
            .AddFilter("Microsoft", LogLevel.Information); //System logs can be filtered.

        return builder.Build();
    }
}
