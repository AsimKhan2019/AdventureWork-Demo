using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Data.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Entity> GetRepository<Entity>() where Entity : class;

        bool Save();

        ValidationResult Validate();

        bool CheckDB();
    }
}
