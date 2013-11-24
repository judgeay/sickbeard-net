using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SickBeard.NET.ViewModel
{
    public class AddShowViewModel : ViewModelBase
    {
        private string _tvShowName;
        private ObservableCollection<TVShow> _tvShows;

        public string TVShowName
        {
            get { return _tvShowName; }
            set
            {
                _tvShowName = value;
                RaisePropertyChanged("TVShowName");
            }
        }

        public ObservableCollection<TVShow> TVShows
        {
            get { return _tvShows; }
            set
            {
                _tvShows = value;
                RaisePropertyChanged("TVShows");
            }
        }
    }
}
