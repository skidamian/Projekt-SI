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
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using PaymentManagement.View;
using Infrastructure;

namespace PaymentManagement
{
    public class PaymentManagementInit : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        private readonly IEventAggregator eventAggregator;

        public PaymentManagementInit(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.container = container;
            this.eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            container.RegisterType<object, PaymentManagementNavigationView>("PaymentManagementNavigationView");
            container.RegisterType<object, PaymentManagementMainView>("PaymentManagementMainView");
            this.regionManager.AddToRegion(RegionNames.NavigationRegion, container.Resolve<PaymentManagementNavigationView>());
            this.eventAggregator.GetEvent<RegistryNavigationViewsEvent>().Subscribe(this.registryNavigationView, true);
        }

        private void registryNavigationView(string moduleName)
        {
            if (moduleName == ModuleNames.EmployeeManagementModule)
            {
                this.regionManager.AddToRegion(RegionNames.NavigationRegion,
                                             container.Resolve<PaymentManagementNavigationView>());
            }
        }
    }
}
