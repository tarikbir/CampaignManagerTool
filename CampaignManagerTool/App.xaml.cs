using System;
using System.Windows;

namespace CampaignManagerTool
{
    public partial class App : Application
    {
        #if DEBUG
            Boolean debug = true;
        #else
            Boolean debug = false;
        #endif

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (debug)
            {
                TestWindow test = new TestWindow();
                test.Show();
            }
            else
            {
                MainWindow mainView = new MainWindow();
                mainView.Show();
            }
        }
    }
}
