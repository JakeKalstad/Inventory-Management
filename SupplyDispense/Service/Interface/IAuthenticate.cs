using SupplyDispense.Enum;
using SupplyDispense.Model.Interface;

namespace SupplyDispense.Service.Interface
{
    public interface IAuthenticate
    {
        RuleResult IsAuthenticated(ILoginModel model);
    }
}