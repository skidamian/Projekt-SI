﻿using System;
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
using Search.View;
using Infrastructure;

namespace Search
{
    public class SearchInit : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        private readonly IEventAggregator eventAggregator;

        public SearchInit(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.container = container;
            this.eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            container.RegisterType<object, SearchNavigationView>("SearchNavigationView");
            container.RegisterType<object, SearchMainView>("SearchMainView");
            this.regionManager.AddToRegion(RegionNames.NavigationRegion, container.Resolve<SearchNavigationView>());
            this.eventAggregator.GetEvent<RegistryNavigationViewsEvent>().Subscribe(this.registryNavigationView, true);
        }

        private void registryNavigationView(string moduleName)
        {
            if (moduleName == ModuleNames.SearchModule)
            {
                this.regionManager.AddToRegion(RegionNames.NavigationRegion,
                                             container.Resolve<SearchNavigationView>());
            }
        }
    }
}
