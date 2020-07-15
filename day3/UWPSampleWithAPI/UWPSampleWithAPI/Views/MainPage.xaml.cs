using System;

using UWPSampleWithAPI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPSampleWithAPI.Views
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
