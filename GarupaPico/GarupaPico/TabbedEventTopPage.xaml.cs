using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarupaPico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedEventTopPage : TabbedPage
    {
        public TabbedEventTopPage ()
        {
            InitializeComponent();
        }
    }
}