using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarupaPico.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppHeader : TemplatedView
	{
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(AppHeader), string.Empty);

        public static readonly BindableProperty TitleIconProperty =
            BindableProperty.Create(nameof(TitleIcon), typeof(string), typeof(AppHeader), string.Empty);

        public static readonly BindableProperty TitleHorizontalOptionsProperty =
            BindableProperty.Create(nameof(TitleHorizontalOptions), typeof(LayoutOptions), typeof(AppHeader), LayoutOptions.Start);

        public static readonly BindableProperty LeftButtonTextProperty =
            BindableProperty.Create(nameof(LeftButtonText), typeof(string), typeof(AppHeader), string.Empty);

        public static readonly BindableProperty LeftButtonCommandProperty =
            BindableProperty.Create(nameof(LeftButtonCommand), typeof(ICommand), typeof(AppHeader));

        public static readonly BindableProperty IsLeftButtonVisibleProperty =
            BindableProperty.Create(nameof(IsLeftButtonVisible), typeof(bool), typeof(AppHeader), true);

        public static readonly BindableProperty IsLeftButtonEnabledProperty =
            BindableProperty.Create(nameof(IsLeftButtonEnabled), typeof(bool), typeof(AppHeader), true);

        public static readonly BindableProperty MiddleButtonTextProperty =
            BindableProperty.Create(nameof(MiddleButtonText), typeof(string), typeof(AppHeader), string.Empty);

        public static readonly BindableProperty MiddleButtonCommandProperty =
            BindableProperty.Create(nameof(MiddleButtonCommand), typeof(ICommand), typeof(AppHeader));

        public static readonly BindableProperty IsMiddleButtonVisibleProperty =
            BindableProperty.Create(nameof(IsMiddleButtonVisible), typeof(bool), typeof(AppHeader), true);

        public static readonly BindableProperty IsMiddleButtonEnabledProperty =
            BindableProperty.Create(nameof(IsMiddleButtonEnabled), typeof(bool), typeof(AppHeader), true);

        public static readonly BindableProperty RightButtonTextProperty =
            BindableProperty.Create(nameof(RightButtonText), typeof(string), typeof(AppHeader), string.Empty);

        public static readonly BindableProperty RightButtonCommandProperty =
            BindableProperty.Create(nameof(RightButtonCommand), typeof(ICommand), typeof(AppHeader));

        public static readonly BindableProperty IsRightButtonVisibleProperty =
            BindableProperty.Create(nameof(IsRightButtonVisible), typeof(bool), typeof(AppHeader), true);

        public static readonly BindableProperty IsRightButtonEnabledProperty =
            BindableProperty.Create(nameof(IsRightButtonEnabled), typeof(bool), typeof(AppHeader), true);

        public AppHeader()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string TitleIcon
        {
            get => (string)GetValue(TitleIconProperty);
            set => SetValue(TitleIconProperty, value);
        }

        public LayoutOptions TitleHorizontalOptions
        {
            get => (LayoutOptions)GetValue(TitleHorizontalOptionsProperty);
            set => SetValue(TitleHorizontalOptionsProperty, value);
        }

        public string LeftButtonText
        {
            get => (string)GetValue(LeftButtonTextProperty);
            set => SetValue(LeftButtonTextProperty, value);
        }

        public ICommand LeftButtonCommand
        {
            get => (ICommand)GetValue(LeftButtonCommandProperty);
            set => SetValue(LeftButtonCommandProperty, value);
        }

        public bool IsLeftButtonVisible
        {
            get => (bool)GetValue(IsLeftButtonVisibleProperty);
            set => SetValue(IsLeftButtonVisibleProperty, value);
        }

        public bool IsLeftButtonEnabled
        {
            get => (bool)GetValue(IsLeftButtonEnabledProperty);
            set => SetValue(IsLeftButtonEnabledProperty, value);
        }

        public string MiddleButtonText
        {
            get => (string)GetValue(MiddleButtonTextProperty);
            set => SetValue(MiddleButtonTextProperty, value);
        }

        public ICommand MiddleButtonCommand
        {
            get => (ICommand)GetValue(MiddleButtonCommandProperty);
            set => SetValue(MiddleButtonCommandProperty, value);
        }

        public bool IsMiddleButtonVisible
        {
            get => (bool)GetValue(IsMiddleButtonVisibleProperty);
            set => SetValue(IsMiddleButtonVisibleProperty, value);
        }

        public bool IsMiddleButtonEnabled
        {
            get => (bool)GetValue(IsMiddleButtonEnabledProperty);
            set => SetValue(IsMiddleButtonEnabledProperty, value);
        }

        public string RightButtonText
        {
            get => (string)GetValue(RightButtonTextProperty);
            set => SetValue(RightButtonTextProperty, value);
        }

        public ICommand RightButtonCommand
        {
            get => (ICommand)GetValue(RightButtonCommandProperty);
            set => SetValue(RightButtonCommandProperty, value);
        }

        public bool IsRightButtonVisible
        {
            get => (bool)GetValue(IsRightButtonVisibleProperty);
            set => SetValue(IsRightButtonVisibleProperty, value);
        }

        public bool IsRightButtonEnabled
        {
            get => (bool)GetValue(IsRightButtonEnabledProperty);
            set => SetValue(IsRightButtonEnabledProperty, value);
        }
    }
}