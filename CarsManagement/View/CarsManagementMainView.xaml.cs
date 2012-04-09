using System;
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
using CarsManagement.ViewModel;

namespace CarsManagement.View
{
    public partial class CarsManagementMainView : UserControl
    {
        public CarsManagementMainView(MainViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel model = (MainViewModel)this.DataContext;
            model.getListOfAllCars();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
