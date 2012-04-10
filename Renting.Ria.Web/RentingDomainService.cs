
namespace Renting.Ria.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Linq;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using Microsoft.ServiceModel.DomainServices.LinqToSql;


    // Implements application logic using the RentingDataClassesDataContext context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class RentingDomainService : LinqToSqlDomainService<RentingDataClassesDataContext>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        public IQueryable<rezerwacje> GetRezerwacjes()
        {
            return this.DataContext.rezerwacjes;
        }

        public void InsertRezerwacje(rezerwacje rezerwacje)
        {
            this.DataContext.rezerwacjes.InsertOnSubmit(rezerwacje);
        }

        public void UpdateRezerwacje(rezerwacje currentrezerwacje)
        {
            this.DataContext.rezerwacjes.Attach(currentrezerwacje, this.ChangeSet.GetOriginal(currentrezerwacje));
        }

        public void DeleteRezerwacje(rezerwacje rezerwacje)
        {
            this.DataContext.rezerwacjes.Attach(rezerwacje);
            this.DataContext.rezerwacjes.DeleteOnSubmit(rezerwacje);
        }
    }
}


