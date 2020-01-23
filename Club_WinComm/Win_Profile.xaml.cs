using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Club_WinComm
{
    /// <summary>
    /// Interaction logic for Win_Profile.xaml
    /// </summary>
    public partial class Win_Profile : Window
    {
        public Win_Profile()
        {
            InitializeComponent();
        }

        static public Member profile = new Member { firstName = "my profile" };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (profile.imagePath == null)
            {
                profile.imagePath = "";
                this.DataContext = profile;
            }
        }

        private void Profile_Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.PNG; *.JPG)| *.PNG; *.JPG";
            var result = dlg.ShowDialog();

            if (result == true)
            {
                profile.imagePath = dlg.FileName;
                this.DataContext = null;
                this.DataContext = profile;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }
    }
}
