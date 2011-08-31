using System;

namespace SupplyDispense.Model.Interface
{
    public interface IObservableModel
    {
        IObservable<IObservableModel> ConnectionInfoRequest { get; set; }
        IObservable<IObservableModel> ExitRequest { get; set; }
        IObservable<IObservableModel> PrintScreenRequest { get; set; }
        IObservable<IObservableModel> PreviousScreenRequest { get; set; }

        void Listen(Action<IObservableModel> connectionInfoHandler = null,
                    Action<IObservableModel> exitRequestHandler = null,
                    Action<IObservableModel> printScreenHandler = null,
                    Action<IObservableModel> prevScreenHandler = null,
                    Action<IObservableModel> mainMenuHandler = null);
    }
}