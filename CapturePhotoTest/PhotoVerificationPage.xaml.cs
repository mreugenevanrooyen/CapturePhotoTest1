using CapturePhotoTest.ViewModel;
using CommunityToolkit.Maui.Views;

namespace CapturePhotoTest.View;

public partial class PhotoVerificationPage : ContentPage
{
	public PhotoVerificationPage(PhotoVerificationViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }


}