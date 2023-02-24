using CapturePhotoTest.View;
using CapturePhotoTest.ViewModel;

namespace CapturePhotoTest;

public partial class AppShell : Shell
{
    public AppShell(AppViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;


        Routing.RegisterRoute(nameof(PhotoVerificationPage), typeof(PhotoVerificationPage));
 
    }
}
