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
            mainPage.Icon = "main.png";
            var calPage = new NavigationPage(new TabbedCalPage())
            {
                Title = "CAL TOOL",
                // Icon = "cal.png"
            };
            var eventTopPage = new NavigationPage(new TabbedEventTopPage())
            {
                Title = "EVENT TOP INFO",
                // Icon = "eventtop.png"
            };
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
