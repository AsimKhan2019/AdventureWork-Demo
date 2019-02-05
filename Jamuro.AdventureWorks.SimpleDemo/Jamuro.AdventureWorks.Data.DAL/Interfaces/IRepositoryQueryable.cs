using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Data.DAL.Interfaces
{
    interface IRepositoryQueryable<TEntity>
    {
        IQueryable<TEntity> Query();

        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes);

        IQueryable<TEntity> Query(string[] includes);
    }
}
