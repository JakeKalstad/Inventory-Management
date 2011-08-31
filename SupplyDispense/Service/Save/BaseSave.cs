using Domain.Interface;
using SupplyDispense.Service.Interface;

namespace SupplyDispense.Service.Save
{
    public class BaseSave : ISave
    {
        private readonly IDataService _dataService;

        public BaseSave(IDataService dataService)
        {
            _dataService = dataService;
        }

        #region ISave Members

        public void Save()
        {
            _dataService.Save();
        }

        #endregion
    }
}