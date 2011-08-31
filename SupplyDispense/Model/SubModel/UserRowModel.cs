using System;
using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class UserRowModel : BaseModel
    {
        public string UserName { get; set; }
        public long UserKey { get; set; }

        public IObservable<UserRowModel> ResetPasswordRequest { get; set; }
        public IObservable<UserRowModel> ChangeAccessRequest { get; set; }
        public IObservable<UserRowModel> TransactionReportRequest { get; set; }
    }
}