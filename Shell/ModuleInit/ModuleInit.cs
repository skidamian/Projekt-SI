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

namespace Shell.ModuleInit
{
    public class ModuleInit : IModuleInit
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        private readonly IEventAggregator eventAggregator;
        private readonly IModuleManager moduleManager;

        public ModuleInit(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator, IModuleManager moduleManager)
        {
            this.regionManager = regionManager;
            this.container = container;
            this.eventAggregator = eventAggregator;
            this.moduleManager = moduleManager; 
        }


    }
}
