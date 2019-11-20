using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace UnoTalks2019.ViewModels
{
    public class RefreshViewDemoViewModel : BaseViewModel
    {
        public RefreshViewDemoViewModel()
        {
            LoadMoreCommand = new Command(InvokeLoadMore);
            DataList = new ObservableCollection<int>(Enumerable.Range(1, 10));
        }

        public ICommand LoadMoreCommand { get; }

        public ObservableCollection<int> DataList { get; }

        public async void InvokeLoadMore()
        {
            IsBusy = true;
            await foreach (var item in LoadMoreData().ConfigureAwait(false))
            {
                DataList.Add(item);
            }
            IsBusy = false;
        }

        public async IAsyncEnumerable<int> LoadMoreData()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(500);
                yield return DataList.Count + 1;
            }
        }
    }
}
