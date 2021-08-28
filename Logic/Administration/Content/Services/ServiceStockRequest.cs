using System.Threading.Tasks;

namespace Logic.Administration.Content.Services
{
    public interface IServiceStockRequest
    {
        Task<StockRequestListVm> GetListAsync();
        Task<StockRequestDetailsVm> GetDetailsAsync(int? id);

        Task<StockRequestCreateVm> GetCreateAsync();
        Task<StockRequestUpdateVm> GetUpdateAsync(int? id);
        Task<StockRequestDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(StockRequestCreateVm view);
        Task UpdateAsync(StockRequestUpdateVm view);
        Task DeleteAsync(StockRequestDeleteVm view);
    }

    public class StockRequestDeleteVm
    {
    }

    public class StockRequestUpdateVm
    {
    }

    public class StockRequestCreateVm
    {
    }

    public class StockRequestDetailsVm
    {
    }

    public class StockRequestListVm
    {
    }

    public class ServiceStockRequest : IServiceStockRequest
    {
        public Task<StockRequestListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockRequestDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockRequestCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockRequestUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockRequestDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(StockRequestCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(StockRequestUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(StockRequestDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}