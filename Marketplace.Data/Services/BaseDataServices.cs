using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using Marketplace.Entities.Models;

namespace Marketplace.Data.Services
{
    public class BaseDataServices<T> : IDataService<T> where T: IdentityBase, new()
    {
        protected MarketDbContext Db;
        public BaseDataServices()
        {
            this.Db = new MarketDbContext();
        }

        public T Create(T entity)
        {
            Db.Set<T>().Add(entity); // hago un db.set del tipo y lo adjunto
            Db.SaveChanges(); // lo almaceno
            return entity; // guardo el valor
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeModels = "")
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public List<ValidationResult> ValidateModel(T model)
        {
            throw new NotImplementedException();
        }
    }
}