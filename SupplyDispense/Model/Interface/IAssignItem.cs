namespace SupplyDispense.Model.Interface
{
    public interface IAssignItem
    {
        string Name { get; set; }
        string Id { get; set; }
        string Location { get; set; }
        string RestockPoint { get; set; }
        void Clear();
    }
}