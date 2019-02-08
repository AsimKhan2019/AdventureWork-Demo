using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Jamuro.AdventureWorks.Data.DAL.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        #region Get Methods

        TEntity GetById(object id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(bool setAsNoTracking);

        IEnumerable<TEntity> GetAll(bool setAsNoTracking, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetAll(bool setAsNoTracking, string[] includes);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, int? maxNumberOfEntities);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, int? maxNumberOfEntities);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, int? maxNumberOfEntities, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> GetWithSort<TKeySort>(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, int? maxNumberOfEntities, Expression<Func<TEntity, TKeySort>> orderBy, bool descendingOrderBy = false, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, int? maxNumberOfEntities, string[] includes);

        TEntity GetOne(Expression<Func<TEntity, bool>> where);

        TEntity GetOne(Expression<Func<TEntity, bool>> where, bool setAsNoTracking);

        TEntity GetOne(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, params Expression<Func<TEntity, object>>[] includes);

        TEntity GetOne(Expression<Func<TEntity, bool>> where, bool setAsNoTracking, string[] includes);

        #region Get methods with SQL

        ICollection<TEntity> GetWithSQL(string sql);

        #endregion

        #endregion

        #region Create Methods

        /// <summary>
        /// Creates a new empty entity.
        /// </summary>
        TEntity Create();

        /// <summary>
        /// Creates the existing entity.
        /// </summary>
        void Create(TEntity entity);

        #endregion

        #region Update Methods

        /// <summary>
        /// Updates the existing entity.
        /// </summary>
        TEntity Update(TEntity entity);

        #endregion

        #region Delete Methods

        /// <summary>
        /// Delete an entity using its primary key.
        /// </summary>
        void Delete(object id);

        /// <summary>
        /// Delete the given entity.
        /// </summary>
        void Delete(TEntity entity);

        void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> where);

        #endregion

        #region Exists Methods

        bool Exists();

        bool Exists(System.Linq.Expressions.Expression<Func<TEntity, bool>> where);

        #endregion
    }
}
