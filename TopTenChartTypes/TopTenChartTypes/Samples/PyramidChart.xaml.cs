﻿using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TopTenChartTypes
{
    public partial class Pyramid : ContentPage
    {
        public Pyramid()
        {
            InitializeComponent();
            series1.ItemsSource = new ObservableCollection<ExpenditureData>(Database.db1.Table<ExpenditureData>());
        }
    }
}
