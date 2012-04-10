﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Renting.ViewModel;
namespace Renting.View
{
    public partial class RentingMainView : UserControl
    {
        public RentingMainView(MainViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;

        }
    }
}
