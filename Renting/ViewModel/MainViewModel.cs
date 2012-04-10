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
using Renting.Ria;
using Renting.Ria.Web;
using System.ServiceModel.DomainServices.Client;
using System.Collections.Generic;

namespace Renting.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        RentingDomainContext ctx;
            
            public void przyklad()
            {
                ctx = new RentingDomainContext();

               
                try
                {
                    ctx.Load(ctx.GetRezerwacjesQuery(), callback =>
                        {
                            if(callback.HasError)
                            {
                                MessageBox.Show(callback.Error.Message);
                            }
                            else
                            {
                                List<rezerwacje> lista = new List<rezerwacje>(callback.Entities);
                                /*Action<rezerwacje> print = elem => { Console.WriteLine(elem); };

                                lista.ForEach(print);*/
                                System.Console.WriteLine("Hello World !");
                            }
                        },null);

                    
                
                }
                catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
    }
}
