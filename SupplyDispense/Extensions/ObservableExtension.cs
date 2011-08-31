using System;
using System.Collections.Generic;
using SupplyDispense.Enum;

namespace SupplyDispense.Extensions
{
    public static class ObservableExtension
    {
        public static void RequestSheet<T>(this IObservable<T> observed, ISubject<Sheets> subject, Sheets sheet)
        {
            observed.Subscribe(_ => subject.OnNext(sheet));
        }
    }
}