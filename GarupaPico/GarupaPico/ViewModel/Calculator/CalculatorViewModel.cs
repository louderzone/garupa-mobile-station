using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using GarupaPico.Model;

namespace GarupaPico.ViewModel.Calculator
{
    public class CalculatorViewModel : PageViewModelBase
    {
        /// <summary>
        /// Gets the user selected deck
        /// </summary>
        public ObservableCollection<Card> SelectedDeck { get; } = new ObservableCollection<Card>()
        {
            // Demo list
            new Card
            {
                Name = "Kasumi",
                SmallImagePath = "i7tbFwg.png"
            },
            new Card
            {
                Name = "Kanon",
                SmallImagePath = "ubNKnVS.png"
            }
        };

        public CalculatorViewModel()
        {
            Title = "Deck";
        }
    }
}
