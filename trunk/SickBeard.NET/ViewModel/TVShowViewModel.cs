using SickBeard.NET.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SickBeard.NET.ViewModel
{
    public class TVShowViewModel : ViewModelBase
    {
        public void AddTVShow()
        {
            var addTvShow = new AddTVShowView();

            Console.WriteLine(addTvShow.ShowDialog());
        }
    }
}
