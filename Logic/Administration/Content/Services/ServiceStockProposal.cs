using System.Threading.Tasks;

namespace Logic.Administration.Content.Services
{
    public interface IServiceStockProposal
    {
        Task<StockProposalListVm> GetListAsync();
        Task<StockProposalDetailsVm> GetDetailsAsync(int? id);

        Task<StockProposalCreateVm> GetCreateAsync();
        Task<StockProposalUpdateVm> GetUpdateAsync(int? id);
        Task<StockProposalDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(StockProposalCreateVm view);
        Task UpdateAsync(StockProposalUpdateVm view);
        Task DeleteAsync(StockProposalDeleteVm view);
    }

    public class StockProposalDeleteVm
    {
    }

    public class StockProposalUpdateVm
    {
    }

    public class StockProposalCreateVm
    {
    }

    public class StockProposalDetailsVm
    {
    }

    public class StockProposalListVm
    {
    }

    public class ServiceStockProposal : IServiceStockProposal
    {
        public Task<StockProposalListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockProposalDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockProposalCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<StockProposalUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockProposalDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(StockProposalCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(StockProposalUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(StockProposalDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}