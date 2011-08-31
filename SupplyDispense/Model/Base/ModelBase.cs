using System;
using System.ComponentModel;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Model.Base
{
    public class BaseModel : INotifyPropertyChanged, IObservableModel
    {
        public IObservable<IObservableModel> MainMenuRequest { get; set; }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region IObservableModel Members

        public void Listen(Action<IObservableModel> connectionInfoHandler = null,
                           Action<IObservableModel> exitRequestHandler = null,
                           Action<IObservableModel> printScreenHandler = null,
                           Action<IObservableModel> prevScreenHandler = null,
                           Action<IObservableModel> mainMenuHandler = null)
        {
            SetListener(ConnectionInfoRequest, connectionInfoHandler);
            SetListener(ExitRequest, exitRequestHandler);
            SetListener(PrintScreenRequest, printScreenHandler);
            SetListener(PreviousScreenRequest, prevScreenHandler);
            SetListener(MainMenuRequest, mainMenuHandler);
        }

        public IObservable<IObservableModel> ConnectionInfoRequest { get; set; }
        public IObservable<IObservableModel> ExitRequest { get; set; }
        public IObservable<IObservableModel> PrintScreenRequest { get; set; }
        public IObservable<IObservableModel> PreviousScreenRequest { get; set; }

        #endregion

        private static void SetListener(IObservable<IObservableModel> request,
                                        Action<IObservableModel> connectionInfoHandler)
        {
            if (request == null) return;
            request.Subscribe(connectionInfoHandler ?? (_ => { }));
        }

        public void Update()
        {
            if (PropertyChanged == null) return;
            PropertyChanged.Invoke(this, null);
        }
    }
}