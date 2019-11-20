using System;
using System.Windows.Input;
using UnoTalks2019.Views;
using MvvmHelpers;
using Xamarin.Forms;

namespace UnoTalks2019.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            GoToFormsDemoCommand = new Command(InvokeGoToFormsDemo);
            GoToXamlHotReloadDemoCommand = new Command(InvokeGoToXamlHotReloadDemo);
        }

        public ICommand GoToFormsDemoCommand { get; }

        public ICommand GoToXamlHotReloadDemoCommand { get; }

        private void InvokeGoToFormsDemo()
        {
            Application.Current.MainPage.Navigation.PushAsync(new FormsDemoPage());
        }

        private void InvokeGoToXamlHotReloadDemo()
        {
            Application.Current.MainPage.Navigation.PushAsync(new XamlHotReloadDemo());
        }
    }
}
