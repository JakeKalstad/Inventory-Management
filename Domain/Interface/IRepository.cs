using System.Collections.Generic;
using System.Data.Objects.DataClasses;

namespace Domain.Interface
{
    public interface IRepository<T> where T : EntityObject
    {
        T Create();
        IEnumerable<T> Query();
        void Delete(T entity);
    }
}