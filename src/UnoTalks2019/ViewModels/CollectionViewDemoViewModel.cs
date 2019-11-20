using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace UnoTalks2019.ViewModels
{
    public class Artist
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Subtitle { get; set; }

        public static List<Artist> Artists = new List<Artist>
        {
            new Artist
            {
                Name = "Bad Bunny",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/812r+bAyUML.jpg",
                Subtitle = "Latin Trap",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Snoop Dogg",
                ImageUrl = "http://www.hhgroups.com/imagenes/artistas/snoop-dogg-artista.jpg",
                Subtitle = "New Album",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Daddy Yankee",
                ImageUrl = "http://e-cdn-images.deezer.com/images/artist/5f45206580cde1388f71ccc7f8226768/500x500.jpg",
                Subtitle = "King of Reggaetón",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Ariana Grande",
                ImageUrl = "https://content-images.p-cdn.com/images/d6/11/26/56/612a46ad8015bec36381deef/_500W_500H.jpg",
                Subtitle = "New Single",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Siddhartha",
                ImageUrl = "https://i.musicaimg.com/letras/500/2445589.jpg",
                Subtitle = "Playing Near You",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Post Malone",
                ImageUrl = "https://i1.sndcdn.com/avatars-000404451534-thnhi5-t500x500.jpg",
                Subtitle = "Playing Near You",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            },
            new Artist
            {
                Name = "Billie Eilish",
                ImageUrl = "https://y.gtimg.cn/music/photo_new/T001R500x500M0000034MZS446AF7O.jpg",
                Subtitle = "Top Albums",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum."
            }
        };
    }

    public class CollectionViewDemoViewModel : BaseViewModel
    {
        public CollectionViewDemoViewModel()
        {
            LoadData();
            LoadMoreCommand = new Command(LoadData);
        }

        public ObservableCollection<Artist> DataList { get; } = new ObservableCollection<Artist>();

        public ICommand LoadMoreCommand { get; }

        private async void LoadData()
        {
            IsBusy = true;
            await foreach (var item in LoadMoreData().ConfigureAwait(false))
            {
                DataList.Add(item);
            }
            IsBusy = false;
        }

        public async IAsyncEnumerable<Artist> LoadMoreData()
        {
            for (int i = 0; i < Artist.Artists.Count; i++)
            {
                await Task.Delay(500);
                yield return Artist.Artists[i];
            }
        }
    }
}
