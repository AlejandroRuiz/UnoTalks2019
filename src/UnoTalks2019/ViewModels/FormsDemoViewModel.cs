using System;
using System.Windows.Input;
using UnoTalks2019.Views;
using MvvmHelpers;
using Xamarin.Forms;

namespace UnoTalks2019.ViewModels
{
    public class FormsDemoViewModel : BaseViewModel
    {
        public FormsDemoViewModel()
        {
            GoToCollectionViewCommand = new Command(InvokeGoToCollectionView);
            GoToRefreshViewCommand = new Command(InvokeGoToRefreshView);
            GoToHtmlLabelCommand = new Command(InvokeGoToHtmlLabel);
            GoToCarouselViewCommand = new Command(InvokeGoToCarouselView);
        }

        public ICommand GoToCollectionViewCommand { get; }

        public ICommand GoToRefreshViewCommand { get; }

        public ICommand GoToHtmlLabelCommand { get; }

        public ICommand GoToCarouselViewCommand { get; }

        private void InvokeGoToCollectionView()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CollectionViewDemoPage());
        }

        private void InvokeGoToRefreshView()
        {
            Application.Current.MainPage.Navigation.PushAsync(new RefreshViewDemoPage());
        }

        private void InvokeGoToHtmlLabel()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HtmlLabelDemoPage());
        }

        private void InvokeGoToCarouselView()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CarouselViewDemoPage());
        }
    }
}
