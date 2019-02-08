using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Data.DAL;
using Jamuro.AdventureWorks.Data.DAL.Interfaces;
using Jamuro.AdventureWorks.Data.Entities;
using Jamuro.AdventureWorks.Services.Factories;
using Jamuro.AdventureWorks.Data.Entities.Contexts;
using Jamuro.AdventureWorks.Services.Workers.Interfaces;

namespace Jamuro.AdventureWorks.Services.Workers
{
    public class WorkerBase : IWorkerBase
    {

        public WorkerBase()
        {
            //TODO. Create new constructor for getting Unit of Work by using IoC
            this.UnitOfWork = new UnitOfWork<AdventureWorksContext>(new DBAdventureWorksFactory());
        }

        protected IUnitOfWork UnitOfWork { get; set; }


        public bool CheckDB()
        {
            return this.UnitOfWork.CheckDB();
        }

    }
}
