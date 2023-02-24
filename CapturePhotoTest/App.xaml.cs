using CapturePhotoTest.ViewModel;

namespace CapturePhotoTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell(new AppViewModel());
    }
}
