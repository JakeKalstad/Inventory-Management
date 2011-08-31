using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class ShifterModel : BaseModel
    {
        private readonly List<ShiftableItem> _rows;
        private readonly ISubject<IEnumerable<ShiftableItem>> _subject = new Subject<IEnumerable<ShiftableItem>>();
        public Action Handler;

        public ShifterModel()
        {
            _rows = new List<ShiftableItem>();
        }

        public string Title { get; set; }
        public string ActionDescription { get; set; }

        public List<ShiftableItem> Rows
        {
            get { return _rows; }
            set
            {
                _rows.Clear();
                _rows.AddRange(value);
                _subject.OnNext(value);
            }
        }

        public IObservable<IEnumerable<ShiftableItem>> ItemsAdded
        {
            get { return _subject.AsObservable(); }
        }
    }
}