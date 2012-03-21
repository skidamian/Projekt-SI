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
using Infrastructure;
using ReporGenerate.View;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;

namespace ReporGenerate
{
    public class ReporGenerateInit : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        private readonly IEventAggregator eventAggregator;

        public ReporGenerateInit(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.container = container;
            this.eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            container.RegisterType<object, ReporGenerateNavigationView>("ReporGenerateNavigationView");
            container.RegisterType<object, ReporGenerateMainView>("ReporGenerateMainView");
            this.regionManager.AddToRegion(RegionNames.NavigationRegion, container.Resolve<ReporGenerateNavigationView>());
            this.eventAggregator.GetEvent<RegistryNavigationViewsEvent>().Subscribe(this.registryNavigationView, true);
        }

        private void registryNavigationView(string moduleName)
        {
            if (moduleName == ModuleNames.EmployeeManagementModule)
            {
                this.regionManager.AddToRegion(RegionNames.NavigationRegion,
                                             container.Resolve<ReporGenerateNavigationView>());
            }
        }
    }
}
