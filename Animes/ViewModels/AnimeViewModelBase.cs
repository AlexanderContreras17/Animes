using System.Collections.ObjectModel;

namespace Animes.ViewModels
{
    public class AnimeViewModelBase
    {
        public ObservableCollection<Animes> Lista { get; set; } =
            new ObservableCollection<Animes>();
    }
}