using System;
using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;
using SupplyDispense.View.Interface;

namespace SupplyDispense.Controller.Interface
{
    public interface IController
    {
        IObservable<Sheets> SheetRequest { get; }
        ISheet GetSheet();
        IObservableModel GetCoreEventModel();
    }
}