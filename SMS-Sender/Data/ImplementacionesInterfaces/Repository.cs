using SMS_Sender.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SMS_Sender.Data.ImplementacionesInterfaces
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly DbContext Context;

        public Repository(DbContext context) => Context = context;

        public T Get(int id) => Context.Set<T>().Find(id);

        public IEnumerable<T> GetAll() => Context.Set<T>().ToList();

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate) => Context.Set<T>().Where(predicate);

        public void Add(T t) => Context.Set<T>().Add(t);

        public void Remove(T t) => Context.Set<T>().Remove(t);
    }
}