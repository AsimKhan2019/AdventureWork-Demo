using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jamuro.AdventureWorks.Data.Entities;
using Jamuro.AdventureWorks.Data.DAL.Interfaces;

namespace Jamuro.AdventureWorks.Data.DAL
{
    public class UnitOfWork<TContext> : IUnitOfWork, IDisposable
     where TContext : DbContext
    {
        private ConcurrentDictionary<Type, object> m_repositories;
        private IDbContextFactory<TContext> m_contextFactory;
        private TContext m_context;
        private bool m_isDisposed;

        #region Properties

        public TContext Context
        {
            get
            {
                if (m_context == null)
                {
                    m_context = this.m_contextFactory.Create();
                }
                return m_context;
            }
        }

        #endregion Properties

        #region Constructor

        public UnitOfWork(IDbContextFactory<TContext> factory)
        {
            m_contextFactory = factory;
            m_repositories = new ConcurrentDictionary<Type, object>();
        }

        #endregion Constructor

        public bool CheckDB()
        {
            return this.Context.Database.Exists();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return (IRepository<TEntity>)m_repositories.GetOrAdd(typeof(TEntity), new Repository<TEntity>(this.Context));
        }

        public virtual bool Save()
        {
            try
            {
                ValidationResult validation = this.Validate();
                if (validation.IsValid)
                {
                    return this.Context.SaveChanges() > 0;
                }
                else
                {
                    throw new ValidationException(validation);
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                throw;
            }
        }

        public ValidationResult Validate()
        {
            ValidationResult result = new ValidationResult();

            List<String> errorMessages = new List<String>();
            foreach (var error in this.Context.GetValidationErrors())
            {
                error.ValidationErrors.ToList().ForEach(x => { errorMessages.Add($"{x.PropertyName} - {x.ErrorMessage}"); });
            }

            if (errorMessages.Any())
            {
                result.IsValid = false;
                result.ErrorMessages = errorMessages;
            }

            return result;
        }

        #region Dispose Methods

        protected virtual void Dispose(bool disposing)
        {
            if (!this.m_isDisposed)
            {
                if (disposing && m_context != null)
                {
                    m_context.Dispose();
                }
            }
            this.m_isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Methods

    }
}
