
using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CapturePhotoTest.ViewModel
{

    public partial class PhotoVerificationViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool acknowledgeCustomerVisible = false;

        [ObservableProperty]
        private bool captureButtonVisible = false;

        [ObservableProperty]
        private string confirmMessage = "Please confirm that this is your client";

        [ObservableProperty]
        private string customerName = "**";

        [ObservableProperty]
        private int customerPhotoTypeId = 0;

        [ObservableProperty]
        private string fileName;

        [ObservableProperty]
        private byte[] image = new byte[0];

        [ObservableProperty]
        private bool isClientWithMe = false;

        [ObservableProperty]
        private bool isClientWithMeVisible = true;

        [ObservableProperty]
        private bool noAcknowledgeCustomer = false;

        [ObservableProperty]
        private ImageSource photoSource = ImageSource.FromFile("avatar.png");

        [ObservableProperty]
        private ImageSource photoSource2 = ImageSource.FromFile("avatar.png");

        [ObservableProperty]
        private bool photoSource2Visible = false;

        [ObservableProperty]
        private bool photoSourceVisible = true;

        [ObservableProperty]
        private byte[] photoToCompare = new byte[0];

        [ObservableProperty]
        private int photoTypeId = -1;

        [ObservableProperty]
        private bool pickMediaButtonVisible = true;

        [ObservableProperty]
        private string pickMediaText = "Select Photo";

        [ObservableProperty]
        private bool typePickerVisible = false;

        [ObservableProperty]
        private bool uploadButtonVisible = false;

        [ObservableProperty]
        private string uploadPhotoText = "Upload Photo";

        [ObservableProperty]
        private bool yesAcknowledgeCustomer = false;

        private bool customerPhoto = false;
        private IConnectivity _connectivity;
        private int id = 0;
        private string dfConfirmMessage = "Please confirm that this is your client";
        private string noNetworkMessage = "Please upload a copy of your ID document.";
        private string noPhotoMessage = "There is no photo. Please upload a copy of your ID document.";
        private string selectID = "Select ID";
        private string uploadID = "Upload ID";

        public PhotoVerificationViewModel() 
        {
            //CapturePhoto();
        }

        [RelayCommand]
        private async Task CapturePhoto()
        {


            try
            {
                var photo = await TakePhoto();
                if (photo != null)
                {
                    var source = new ByteArrayToImageSourceConverter().ConvertFrom(Image);
                    PhotoSource = null;
                    PhotoSource = source;
                    PhotoToCompare = image;
                    PhotoSourceVisible = true;
                    ConfirmMessage = "";
                                        
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Capture Photo", ex.Message.ToString(), "OK");
            }
            finally
            {
                
            }
        }


        public async Task<byte[]> TakePhoto()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = "Please enter a name"
                });

                if (photo != null)
                {
                    
                    using Stream sourceStream = await photo.OpenReadAsync();
                    Image = new byte[sourceStream.Length];
                    await sourceStream.ReadAsync(Image, 0, Image.Length);
                    return Image;
                }
                else
                {
                  
                }
            }
            return null;
        }

    }
}