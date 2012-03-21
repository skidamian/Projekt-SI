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
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using DBManagement.View;
using Infrastructure;

namespace DBManagement
{
    public class DBManagementInit : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        private readonly IEventAggregator eventAggregator;

        public DBManagementInit(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.container = container;
            this.eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            container.RegisterType<object, DBManagmentNavigationView>("DBManagmentNavigationView");
            container.RegisterType<object, DBManagmentMainView>("DBManagmentMainView");
            this.regionManager.AddToRegion(RegionNames.NavigationRegion, container.Resolve<DBManagmentNavigationView>());
            this.eventAggregator.GetEvent<RegistryNavigationViewsEvent>().Subscribe(this.registryNavigationView, true);
        }

        private void registryNavigationView(string moduleName)
        {
            if (moduleName == ModuleNames.DBManagementModule)
            {
                this.regionManager.AddToRegion(RegionNames.NavigationRegion,
                                             container.Resolve<DBManagmentNavigationView>());
            }
        }
    }
}
