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
            /* TODO. Implement dependency injection */
            this.UnitOfWork = new UnitOfWork<AdventureWorksContext>(new DBAdventureWorksFactory());
        }

        public WorkerBase(IUnitOfWork uow)
        {
            this.UnitOfWork = uow;
        }

        protected IUnitOfWork UnitOfWork { get; private set; }


        public bool CheckDB()
        {
            return this.UnitOfWork.CheckDB();
        }

    }
}
