using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CampaignManagerTool
{
    public partial class TestWindow : Window
    {
        public bool isAddingPin;

        public TestWindow()
        {
            InitializeComponent();
            isAddingPin = false;
        }

        private void btnClick1_Click(object sender, RoutedEventArgs e)
        {
            //import map
            BitmapImage mapImage;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap image files (*.bmp; *.gif; *.png; *.jpg; *.xpm; *.xbm; *.tiff; *.ppm)|*.bmp; *.gif; *.png; *.jpg; *.xpm; *.xbm; *.tif; *.tiff; *.ppm|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    mapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                    imgMap.Source = mapImage;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "An Error Occured", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClick2_Click(object sender, RoutedEventArgs e)
        {
            //add pin
            isAddingPin = true;

        }

        private void btnClick3_Click(object sender, RoutedEventArgs e)
        {
            //clear map?
            imgMap.Source = null;
        }
    }
}
