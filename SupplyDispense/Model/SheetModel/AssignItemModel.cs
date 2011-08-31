using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.SheetModel
{
    public class AssignItemModel : BaseModel, IAssignItem
    {
        private readonly List<string> _locations;
        private readonly ISubject<List<string>> _newLocationsLoaded = new Subject<List<string>>();

        public AssignItemModel()
        {
            _locations = new List<string>();
        }

        public List<string> Locations
        {
            get { return _locations; }
            set
            {
                _locations.Clear();
                _locations.AddRange(value);
                _newLocationsLoaded.OnNext(_locations);
            }
        }

        public IObservable<AssignItemModel> AssignRequest { get; set; }

        public IObservable<List<string>> NewLocationsLoaded
        {
            get { return _newLocationsLoaded.AsObservable(); }
        }

        #region IAssignItem Members

        public string Name { get; set; }
        public string Id { get; set; }
        public string Location { get; set; }
        public string RestockPoint { get; set; }

        public void Clear()
        {
            Name = String.Empty;
            Id = String.Empty;
            Location = String.Empty;
            RestockPoint = String.Empty;
        }

        #endregion
    }
}