using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Service.Interface
{
    public interface ISaveAssignedItem
    {
        RuleResult SaveItem(IAssignItem item);
    }
}