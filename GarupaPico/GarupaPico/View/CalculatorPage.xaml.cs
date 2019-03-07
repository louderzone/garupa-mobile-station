using System;
using GarupaPico.Model;
using GarupaPico.ViewModel.Calculator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarupaPico.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        private CalculatorViewModel _vm;

        public CalculatorPage ()
        {
            InitializeComponent();
            _vm = (CalculatorViewModel) BindingContext;
        }

        /// <summary>
        /// Handles add Yukina button on clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddYukina_OnClicked(object sender, EventArgs e)
        {
            _vm.SelectedDeck.Add(new Card
            {
                Name = "Yukina",
                SmallImagePath = "Fyg182O.png"
            });
        }
    }
}