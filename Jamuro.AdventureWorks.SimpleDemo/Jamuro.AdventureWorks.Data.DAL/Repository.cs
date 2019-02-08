using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Jamuro.AdventureWorks.Data.DAL.Interfaces;


namespace Jamuro.AdventureWorks.Data.DAL
{
    public class Repository<TEntity> : IRepository<TEntity>, IRepositoryQueryable<TEntity>
        where TEntity : class
    {
        static string[] s_EmptyStringArray = new string[] { };

        #region Constructor

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        #region Properties

        protected DbContext Context { get; set; }

        #endregion Properties

        #endregion

        #region Create Methods

        public virtual TEntity Create()
        {
            return this.Context.Set<TEntity>().Create();
        }

        public virtual void Create(TEntity entity)
        {
            this.Context.Entry(entity).State = EntityState.Added;
            this.Context.Set<TEntity>().Add(entity);
        }

        #endregion

        #region Update Methods

        public virtual TEntity Update(TEntity entity)
        {
            DbEntityEntry<TEntity> entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.Context.Set<TEntity>().Attach(entity);
            }
            this.Context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        #endregion

        #region Delete Methods

        public virtual void Delete(object id)
        {
            var item = this.Context.Set<TEntity>().Find(id);
            this.Context.Set<TEntity>().Remove(item);
        }

        public virtual void Delete(TEntity entity)
        {
            if (this.Context.Entry(entity).State == EntityState.Detached)
            {
                this.Context.Set<TEntity>().Attach(entity);
            }
            this.Context.Set<TEntity>().Remove(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            var objects = this.Context.Set<TEntity>().Where(where).AsEnumerable();
            foreach (var item in objects)
            {
                this.Context.Set<TEntity>().Remove(item);
            }
        }

        #endregion

        #region Get Methods

        public virtual TEntity GetById(object id)
        {
            return this.Context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetAll(false);
        }

        public virtual IEnumerable<TEntity> GetAll(bool setAsNoTracking)
        {
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking() : this.Context.Set<TEntity>();
            return query.ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(bool setAsNoTracking, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking() : this.Context.Set<TEntity>();
            foreach (var include in includes)
                query = query.Include(include);
            return query.ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(bool setAsNoTracking, string[] includes)
        {
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking() : this.Context.Set<TEntity>();
            foreach (var include in includes)
                query = query.Include(include);
            return query.ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where)
        {
            return Get(where, false, null, s_EmptyStringArray);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, 
            int? maxNumberOfEntities)
        {
            return Get(where, false, maxNumberOfEntities, s_EmptyStringArray);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            int? maxNumberOfEntities)
        {
            return Get(where, setAsNoTracking, maxNumberOfEntities, s_EmptyStringArray);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            int? maxNumberOfEntities,
            params Expression<Func<TEntity, object>>[] includes            
            )
        {
            
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking().Where(where) : this.Context.Set<TEntity>().Where(where);
            
            foreach (var include in includes)
                query = query.Include(include);

            return maxNumberOfEntities != null && maxNumberOfEntities.Value > 0 ? query.Take(maxNumberOfEntities.Value).ToList() : query.ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where, 
            bool setAsNoTracking,
            int? maxNumberOfEntities,
            string[] includes)
        {
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking().Where(where) : this.Context.Set<TEntity>().Where(where);
            foreach (var include in includes)
                query = query.Include(include);

            return maxNumberOfEntities != null && maxNumberOfEntities.Value > 0 ? query.Take(maxNumberOfEntities.Value).ToList() : query.ToList();
        }

        public virtual IEnumerable<TEntity> GetWithSort<TKeySort>(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            int? maxNumberOfEntities,
            Expression<Func<TEntity, TKeySort>> orderBy,
            bool descendingOrderBy = false,
            params Expression<Func<TEntity, object>>[] includes
            )
        {

            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking().Where(where) : this.Context.Set<TEntity>().Where(where);

            foreach (var include in includes)
                query = query.Include(include);

            if (orderBy != null)
            {
                query = descendingOrderBy ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);
            }

            return maxNumberOfEntities != null && maxNumberOfEntities.Value > 0 ? query.Take(maxNumberOfEntities.Value).ToList() : query.ToList();
        }


        public virtual IEnumerable<TOutputModel> GetWithNewOutputModel<TKeySort, TOutputModel>(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            int? maxNumberOfEntities,            
            Expression<Func<TEntity, TOutputModel>> selectOutputModel,
            Expression<Func<TEntity, TKeySort>> orderBy,
            bool descendingOrderBy = false,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = setAsNoTracking ? this.Context.Set<TEntity>().AsNoTracking().Where(where) : this.Context.Set<TEntity>().Where(where);
            foreach (var include in includes)
                query = query.Include(include);

            if (orderBy != null)
            {
                query = descendingOrderBy ? query.OrderByDescending(orderBy) : query.OrderBy(orderBy);
            }

            query = maxNumberOfEntities != null && maxNumberOfEntities.Value > 0 ? query.Take(maxNumberOfEntities.Value) : query;

            return query.Select(selectOutputModel).ToList();
        }

        #endregion

        #region Get One Methods

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> where)
        {
            return Get(where, false, 1, s_EmptyStringArray).FirstOrDefault();
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking)
        {
            return Get(where, setAsNoTracking, 1, s_EmptyStringArray).FirstOrDefault();
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            params Expression<Func<TEntity, object>>[] includes)
        {
            return Get(where, setAsNoTracking, 1, includes).FirstOrDefault();
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> where,
            bool setAsNoTracking,
            string[] includes)
        {
            return Get(where, setAsNoTracking, 1, includes).FirstOrDefault();
        }

        #endregion

        #region Get With SQL

        public ICollection<TEntity> GetWithSQL(string sql)
        {
            return Context.Database.SqlQuery<TEntity>(sql).ToList();
        }

        #endregion

        public IQueryable<TEntity> Query()
        {
            return Query(s_EmptyStringArray);
        }

        public virtual IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = from x in Context.Set<TEntity>()
                                        select x;
            foreach (var include in includes)
                query = query.Include(include);
            return query;
        }

        public virtual IQueryable<TEntity> Query(string[] includes)
        {
            IQueryable<TEntity> query = from x in Context.Set<TEntity>()
                                        select x;
            foreach (var include in includes)
                query = query.Include(include);
            return query;
        }

        #region Exists Methods

        public virtual bool Exists()
        {
            return this.Context.Set<TEntity>().AsNoTracking().Any();
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> where)
        {
            return this.Context.Set<TEntity>().AsNoTracking().Where(where).Any();
        }

        #endregion

    }
}
