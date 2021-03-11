using System;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace FakeGimp
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        async void load_image(object sender, RoutedEventArgs e)
        {
            FileOpenPicker open = new FileOpenPicker();
            open.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            open.ViewMode = PickerViewMode.Thumbnail;

            open.FileTypeFilter.Clear();
            open.FileTypeFilter.Add(".bmp");
            open.FileTypeFilter.Add(".png");
            open.FileTypeFilter.Add(".jpeg");
            open.FileTypeFilter.Add(".jpg");

            StorageFile file = await open.PickSingleFileAsync();

            if (file != null)
            {
                using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    await bitmapImage.SetSourceAsync(fileStream);
                    EditedImage.Source = bitmapImage;
                }
            }
        }

        private void zesileni_cerveny(object sender, RoutedEventArgs e)
        {

        }

        private void zesileni_zeleny(object sender, RoutedEventArgs e)
        {

        }

        private void zesileni_modre(object sender, RoutedEventArgs e)
        {

        }

        private void odstiny_cervene(object sender, RoutedEventArgs e)
        {

        }

        private void odstiny_zelene(object sender, RoutedEventArgs e)
        {

        }

        private void odstiny_modre(object sender, RoutedEventArgs e)
        {

        }

        private void odstiny_sede(object sender, RoutedEventArgs e)
        {

        }

        private void sepie(object sender, RoutedEventArgs e)
        {

        }

        private void negativ(object sender, RoutedEventArgs e)
        {

        }

        private void redukce_1_2(object sender, RoutedEventArgs e)
        {

        }

        private void redukce_1_4(object sender, RoutedEventArgs e)
        {

        }

        private void redukce_1_8(object sender, RoutedEventArgs e)
        {

        }

        private void rozostreni(object sender, RoutedEventArgs e)
        {

        }

        private void vratit_zmeny(object sender, RoutedEventArgs e)
        {

        }
    }
}
