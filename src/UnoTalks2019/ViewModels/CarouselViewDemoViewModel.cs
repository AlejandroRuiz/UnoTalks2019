using System;
using System.Collections.ObjectModel;
using MvvmHelpers;
using Xamarin.Forms;

namespace UnoTalks2019.ViewModels
{
    public class CarouselViewItem
    {
        public string Title { get; set; }

        public string Details { get; set; }

        public Color Color1 { get; set; }

        public Color Color2 { get; set; }
    }

    public class CarouselViewDemoViewModel : BaseViewModel
    {
        private Random rnd = new Random();

        public CarouselViewDemoViewModel()
        {
            DataList = new ObservableCollection<CarouselViewItem>
            {
                new CarouselViewItem
                {
                    Title = "Awesome Feature 1",
                    Details = "Awesome Xamarin Forms Features",
                    Color1 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Color2 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                },
                new CarouselViewItem
                {
                    Title = "Awesome Feature 2",
                    Details = "Awesome Xamarin Forms Features",
                    Color1 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Color2 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                },
                new CarouselViewItem
                {
                    Title = "Awesome Feature 3",
                    Details = "Awesome Xamarin Forms Features",
                    Color1 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Color2 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                },
                new CarouselViewItem
                {
                    Title = "Awesome Feature 4",
                    Details = "Awesome Xamarin Forms Features",
                    Color1 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Color2 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                },
                new CarouselViewItem
                {
                    Title = "Awesome Feature 5",
                    Details = "Awesome Xamarin Forms Features",
                    Color1 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Color2 =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                }
            };
        }

        public ObservableCollection<CarouselViewItem> DataList { get; }
    }
}
