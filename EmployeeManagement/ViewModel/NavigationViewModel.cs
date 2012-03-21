using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Infrastructure;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Commands;
using System.Linq;

namespace EmployeeManagement.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        private static Uri MainView = new Uri("EmployeeManagementMainView", UriKind.Relative);
        IRegionManager regionManager;
        IUnityContainer container;

        public NavigationViewModel(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
            ShowMainViewCommand = new DelegateCommand(ShowMainView);
        }

        public DelegateCommand ShowMainViewCommand { get; set; }

        private void ShowMainView()
        {
            IRegion region = regionManager.Regions[RegionNames.MainRegion];
            if (region.Views.FirstOrDefault() != null)
                region.Remove(region.Views.First());
            regionManager.RequestNavigate(RegionNames.MainRegion, MainView);
        }
    }
}
