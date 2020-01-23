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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class W_Client : Window
    {
        public W_Client()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_members.ItemsSource = App._members;
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Lbx_members.ItemsSource = App._members;
        }

        private void Lbx_members_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl_mobile.SelectedIndex = 1;
        }

        private void Btn_Profile_Click(object sender, RoutedEventArgs e)
        {
            var win_profile = new Win_Profile();
            win_profile.Owner = this;
            win_profile.Height = Height;
            win_profile.Width = Width;
            win_profile.Show();
            Visibility = Visibility.Collapsed;
        }
    }
}
