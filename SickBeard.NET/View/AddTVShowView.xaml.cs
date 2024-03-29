﻿using SickBeard.NET.ViewModel;
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
using System.Windows.Shapes;

namespace SickBeard.NET.View
{
    /// <summary>
    /// Logique d'interaction pour AddShow.xaml
    /// </summary>
    public partial class AddTVShowView : Window
    {
        public AddTVShowView()
        {
            InitializeComponent();

            this.DataContext = new AddTVShowViewModel();

            txtBlockTvShowName.Focus();
        }

        private void TVShowSearch()
        {
            var vm = this.DataContext as AddTVShowViewModel;
            if (vm == null) return;

            var tvShowsList = TVShow.FromTheTVDB(vm.TVShowName);
            if (tvShowsList == null) return;

            vm.TVShows = new System.Collections.ObjectModel.ObservableCollection<TVShow>(tvShowsList);
        }

        private void Window_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txtBlockTvShowName.IsFocused && e.Key == Key.Enter)
                TVShowSearch();
        }

        private void btnSearch_Click_1(object sender, RoutedEventArgs e)
        {
            TVShowSearch();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
