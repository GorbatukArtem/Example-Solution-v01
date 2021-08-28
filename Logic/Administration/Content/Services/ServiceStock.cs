using System.Threading.Tasks;

namespace Logic.Administration.Content.Services
{
    public interface IServiceStock
    {
        Task<StockListVm> GetListAsync();
        Task<StockDetailsVm> GetDetailsAsync(int? id);

        Task<StockCreateVm> GetCreateAsync();
        Task<StockUpdateVm> GetUpdateAsync(int? id);
        Task<StockDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(StockCreateVm view);
        Task UpdateAsync(StockUpdateVm view);
        Task DeleteAsync(StockDeleteVm view);
    }

    public class StockDeleteVm
    {
    }

    public class StockUpdateVm
    {
    }

    public class StockCreateVm
    {
    }

    public class StockDetailsVm
    {
    }

    public class StockListVm
    {
    }

    public class ServiceStock : IServiceStock
    {
        public Task<StockListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(StockCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(StockUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(StockDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}