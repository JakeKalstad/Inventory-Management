using System.Collections.Generic;
using System.Data.Objects.DataClasses;

namespace Domain.Interface
{
    public interface IDataService
    {
        T Create<T>() where T : EntityObject;
        IEnumerable<T> Query<T>() where T : EntityObject;
        void Delete<T>(T entity) where T : EntityObject;
        void Save();
    }
}