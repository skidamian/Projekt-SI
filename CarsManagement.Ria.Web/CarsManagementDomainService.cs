
namespace CarsManagement.Ria.Web
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


    // Implements application logic using the CarsManagementDataClassesDataContext context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class CarsManagementDomainService : LinqToSqlDomainService<CarsManagementDataClassesDataContext>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        public IQueryable<samochody> GetSamochodies()
        {
            return this.DataContext.samochodies;
        }

        public void InsertSamochody(samochody samochody)
        {
            this.DataContext.samochodies.InsertOnSubmit(samochody);
        }

        public void UpdateSamochody(samochody currentsamochody)
        {
            this.DataContext.samochodies.Attach(currentsamochody, this.ChangeSet.GetOriginal(currentsamochody));
        }

        public void DeleteSamochody(samochody samochody)
        {
            this.DataContext.samochodies.Attach(samochody);
            this.DataContext.samochodies.DeleteOnSubmit(samochody);
        }
    }
}


