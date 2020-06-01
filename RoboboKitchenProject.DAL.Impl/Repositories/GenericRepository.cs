using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using RoboboKitchenProject.DAL.Abstract;

namespace RoboboKitchenProject.DAL.Impl
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly RoboboDataContext _dataContext;
        public GenericRepository(RoboboDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            _dataContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }

        public List<T> ListEntities()
        {
            return _dataContext.Set<T>().ToList();
        }

        public List<T> ListEntities(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _dataContext.Entry<T>(entity).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }
    }
  
  
}
