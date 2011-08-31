using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Location
{
    public class FetchLocations : IFetchLocations
    {
        private readonly IRepository<location> _locationRepo;

        public FetchLocations(IRepository<location> locationRepo)
        {
            _locationRepo = locationRepo;
        }

        #region IFetchLocations Members

        public IEnumerable<location> Fetch(Func<location, bool> predicate = null)
        {
            return _locationRepo.Query()
                .Where(predicate ?? (_ => true))
                .ToList();
        }

        #endregion
    }
}