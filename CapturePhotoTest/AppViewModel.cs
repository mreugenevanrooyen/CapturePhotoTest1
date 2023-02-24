using CapturePhotoTest.View;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CapturePhotoTest.ViewModel
{
    public partial class AppViewModel : ObservableObject
    {
        [ObservableProperty]
        string version;
    }
}
