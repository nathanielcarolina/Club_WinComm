using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Club_WinComm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Member> _members;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // get the data needed
            _members = GenerateMembers(20);
        }

        private List<Member> GenerateMembers(int cnt)
        {
            var lst = new List<Member>();
            for (int i = 0; i < cnt; i++)
            {
                lst.Add(new Member { firstName = "fn" + i, lastName = "ln" + i });
            }
            return lst;
        }
    }
}
