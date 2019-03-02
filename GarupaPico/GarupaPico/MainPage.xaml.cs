using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GarupaPico
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            var mainPage = this;
            mainPage.Title = "MAIN";
            // mainPage.Icon = "main.png";
            var calPage = new NavigationPage(new TabbedCalPage());
            // calPage.Icon = "cal.png";
            calPage.Title = "CAL TOOL";
            var eventTopPage = new NavigationPage(new TabbedEventTopPage());
            eventTopPage.Title = "EVENT TOP INFO";
            // eventTopPage.Icon = "eventtop.png";
            Children.Add(calPage);
            Children.Add(eventTopPage);

            InitializeComponent();
        }

        private void LaunchCalTool_OnClicked(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
