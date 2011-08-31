namespace SupplyDispense.Service.Interface
{
    public interface IChangePassword
    {
        void ResetPassword(string name, string newPass);
        void ResetPassword(long userKey);
    }
}