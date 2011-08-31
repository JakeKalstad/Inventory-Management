using SupplyDispense.Model.Base;

namespace SupplyDispense.Model.SubModel
{
    public class RestockHistoryRowModel : BaseModel
    {
        public string RestockNumber { get; set; }
        public string RestockDate { get; set; }
        public string UserName { get; set; }
    }
}