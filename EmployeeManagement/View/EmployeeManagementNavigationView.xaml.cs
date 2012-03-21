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
using EmployeeManagement.ViewModel;

namespace EmployeeManagement.View
{
    public partial class EmployeeManagementNavigationView : UserControl
    {
        public EmployeeManagementNavigationView(NavigationViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
