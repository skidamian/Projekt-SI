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
using System.Linq;

using CarsManagement.Ria;
using CarsManagement.Ria.Web;
using System.ServiceModel.DomainServices.Client;
using System.Collections.Generic;

namespace CarsManagement.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        CarsManagementDomainContext service = new CarsManagementDomainContext();

        private List<samochody> listOfAllCars;

        public MainViewModel()
        {
        }

        public List<samochody> ListOfAllCars
        {
            get { return listOfAllCars; }
            set
            {
                listOfAllCars = value;
                this.NotifyPropertyChanged("ListOfAllCars");
            }
        }

        public void getListOfAllCars()
        {
            service.Load(service.GetSamochodiesQuery(), callback =>
                {
                    ListOfAllCars = new List<samochody>(callback.Entities);
                }
            , null);
        }
    }
}
