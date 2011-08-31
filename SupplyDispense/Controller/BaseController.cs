using System;
using System.Collections.Generic;
using System.Linq;
using SupplyDispense.Controller.Interface;
using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller
{
    public class BaseController : IController
    {
        protected readonly ISubject<Sheets> SheetRequester;
        private readonly IObservableModel _model;
        private readonly ISheet _sheet;

        public BaseController(IObservableModel model, ISheet sheet)
        {
            _model = model;
            SheetRequester = new Subject<Sheets>();
            _sheet = sheet;
        }

        #region IController Members

        public virtual ISheet GetSheet()
        {
            return _sheet;
        }

        public IObservable<Sheets> SheetRequest
        {
            get { return SheetRequester.AsObservable(); }
        }

        public IObservableModel GetCoreEventModel()
        {
            return _model;
        }

        #endregion

        protected ISheet GetSheet(Action preFetch)
        {
            preFetch();
            return _sheet;
        }
    }
}