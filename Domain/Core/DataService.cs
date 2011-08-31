using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using Domain.Interface;

namespace Domain.Core
{
    public class DataService : IDataService
    {
        private readonly supplyEntities _entities;
        private readonly Dictionary<Type, string> _setMap;

        public DataService()
        {
            _entities = new supplyEntities();
            _setMap = new Dictionary<Type, string>
                          {
                              {typeof (item), _entities.items.EntitySet.Name},
                              {typeof (location), _entities.locations.EntitySet.Name},
                              {typeof (itemlookup), _entities.itemlookups.EntitySet.Name},
                              {typeof (user), _entities.users.EntitySet.Name},
                              {typeof (usertype), _entities.usertypes.EntitySet.Name},
                              {typeof (restockhistory), _entities.restockhistories.EntitySet.Name},
                          };
        }

        #region IDataService Members

        public T Create<T>() where T : EntityObject
        {
            var entity = _entities.CreateObject<T>();
            _entities.AddObject(_setMap[typeof (T)], entity);
            return entity;
        }

        public IEnumerable<T> Query<T>() where T : EntityObject
        {
            _entities.ContextOptions.LazyLoadingEnabled = true;
            return _entities.CreateObjectSet<T>();
        }

        public void Delete<T>(T entity) where T : EntityObject
        {
            _entities.DeleteObject(entity);
        }

        public void Save()
        {
            _entities.SaveChanges(SaveOptions.DetectChangesBeforeSave);
            _entities.AcceptAllChanges();
        }

        #endregion
    }
}