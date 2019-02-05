using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Configuration;
using Jamuro.AdventureWorks.Data.Entities.Contexts;

namespace Jamuro.AdventureWorks.Services.Factories
{
    public class DBAdventureWorksFactory : IDbContextFactory<AdventureWorksContext>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public DBAdventureWorksFactory()
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        public AdventureWorksContext Create()
        {
            //Here we need to get the current user to search in the MetadataDB which DB belongs to the user
            AdventureWorksContext context = new AdventureWorksContext(this.GetUserConnectionString());
            return context;
        }

        private string GetUserConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
        }

    }
}
