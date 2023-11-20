using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using Animes.Models;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System.IO;

namespace Animes.ViewModels
{
    public class AnimeViewModel
    {
        public ObservableCollection<Animes> Lista { get; set; } =
            new ObservableCollection<Animes>();
    }
}
