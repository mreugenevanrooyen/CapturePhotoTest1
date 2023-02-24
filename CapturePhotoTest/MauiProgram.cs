using CapturePhotoTest.View;
using CapturePhotoTest.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace CapturePhotoTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiCommunityToolkit()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<PhotoVerificationPage>();
        builder.Services.AddSingleton<PhotoVerificationViewModel>();
        return builder.Build();
	}
}
