using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace Club_WinComm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<Member> _members;
        DispatcherTimer timer = new DispatcherTimer();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // get the data needed
            //_members = GenerateMembers(20);
            _members = MyStorage.ReadXml<ObservableCollection<Member>>("ClubMembers.xml");
            if (_members == null)
            {
                _members = new ObservableCollection<Member>();
            }
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private ObservableCollection<Member> GenerateMembers(int cnt)
        {
            var lst = new ObservableCollection<Member>();
            for (int i = 0; i < cnt; i++)
            {
                lst.Add(new Member { firstName = "fn" + i, lastName = "ln" + i });
            }
            return lst;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MyStorage.WriteXml<ObservableCollection<Member>>(_members, "ClubMembers.xml");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var mem = GenerateMembers(1);
            _members.Add(mem[0]);
        }

    }
}
