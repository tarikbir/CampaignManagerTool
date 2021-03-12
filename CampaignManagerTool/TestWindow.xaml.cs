using System.Windows;

namespace CampaignManagerTool
{
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            SetUIForTest();

            UpdateLabel();
        }

        private void btnClick1_Click(object sender, RoutedEventArgs e)
        {
            UpdateLabel();
        }

        private void btnClick2_Click(object sender, RoutedEventArgs e)
        {
            UpdateLabel();
        }

        private void btnClick3_Click(object sender, RoutedEventArgs e)
        {
            UpdateLabel();
        }

        public void SetUIForTest(string btn1 = default, string btn2 = default, string btn3 = default)
        {
            btnClick1.Content = btn1;
            btnClick2.Content = btn2;
            btnClick3.Content = btn3;
        }

        public void UpdateLabel(string newText = default)
        {
            lblTextBox.Content = newText;
        }
    }
}
