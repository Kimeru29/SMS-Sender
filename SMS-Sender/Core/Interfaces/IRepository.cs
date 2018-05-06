using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SMS_Sender.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T t);

        void Remove(T t);
    }
}
