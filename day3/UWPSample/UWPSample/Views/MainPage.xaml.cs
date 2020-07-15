using System;

using UWPSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
