﻿using System;

using Xamarin.Forms;

namespace TopTenChartTypes
{
    public partial class SaveAsImage : ContentPage
    {
        public SaveAsImage()
        {
            InitializeComponent();
        }
        public void OnButtonClick(object sender, EventArgs e)
        {
            sfchart.SaveAsImage("Chart_Sample.jpg");
        }
    }
}
