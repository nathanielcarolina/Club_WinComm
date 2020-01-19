using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Club_WinComm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_members.ItemsSource = App._members;
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = Tbx_filter.Text.ToLower();
            var lst = from m in App._members where m.firstName.Contains(input) select m;
            Lbx_members.ItemsSource = lst;
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            var mem = new Member { firstName = "Please edit", lastName = "Please edit" };
            App._members.Add(mem);

        }
    }
}
