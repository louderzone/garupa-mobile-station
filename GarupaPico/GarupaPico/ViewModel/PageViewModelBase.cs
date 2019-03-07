using System.Windows.Input;

namespace GarupaPico.ViewModel
{
    public abstract class PageViewModelBase : BindableBase
    {
        private string _title;
        private string _titleIcon;
        private ICommand _appBarLeftButtonCommand;
        private ICommand _appBarMiddleButtonCommand;
        private ICommand _appBarRightButtonCommand;

        /// <summary>
        /// Gets or sets the page title
        /// </summary>
        public string Title
        {
            get => _title;
            protected set
            {
                if (_title == value) return;
                _title = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the page icon
        /// </summary>
        public string TitleIcon
        {
            get => _titleIcon;
            protected set
            {
                if (_titleIcon == value) return;
                _titleIcon = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the action of the left command bar button
        /// </summary>
        public ICommand AppBarLeftButtonCommand
        {
            get => _appBarLeftButtonCommand;
            protected set
            {
                if (_appBarLeftButtonCommand == value) return;
                _appBarLeftButtonCommand = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the action of the right command bar button
        /// </summary>
        public ICommand AppBarRightButtonCommand
        {
            get => _appBarRightButtonCommand;
            protected set
            {
                if (_appBarRightButtonCommand == value) return;
                _appBarRightButtonCommand = value;
                OnPropertyChanged();
            }
        }
    }
}
