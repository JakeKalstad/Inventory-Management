using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using Domain.Interface;

namespace Domain.Core
{
    public class Repository<T> : IRepository<T> where T : EntityObject
    {
        private readonly IDataService _dataService;

        public Repository(IDataService dataService)
        {
            _dataService = dataService;
        }

        #region IRepository<T> Members

        public T Create()
        {
            return _dataService.Create<T>();
        }

        public IEnumerable<T> Query()
        {
            return _dataService.Query<T>();
        }

        public void Delete(T entity)
        {
            _dataService.Delete(entity);
        }

        #endregion
    }
}