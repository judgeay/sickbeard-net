using SickBeard.NET.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SickBeard.NET.View
{
    /// <summary>
    /// Logique d'interaction pour TVShowsView.xaml
    /// </summary>
    public partial class TVShowView : UserControl
    {
        public TVShowView()
        {
            InitializeComponent();

            this.DataContext = new TVShowViewModel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var tvShowViewModel = this.DataContext as TVShowViewModel;

            if (tvShowViewModel == null) return;

            tvShowViewModel.AddTVShow();
        }
    }
}
