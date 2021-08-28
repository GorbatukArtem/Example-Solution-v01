using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanMotivations
{
    public interface IServiceReward
    {
        Task<RewardListVm> GetListAsync();
        Task<RewardDetailsVm> GetDetailsAsync(int? id);

        Task<RewardCreateVm> GetCreateAsync();
        Task<RewardUpdateVm> GetUpdateAsync(int? id);
        Task<RewardDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RewardCreateVm view);
        Task UpdateAsync(RewardUpdateVm view);
        Task DeleteAsync(RewardDeleteVm view);
    }

    public class RewardDeleteVm
    {
    }

    public class RewardUpdateVm
    {
    }

    public class RewardCreateVm
    {
    }

    public class RewardDetailsVm
    {
    }

    public class RewardListVm
    {
    }

    public class ServiceReward : IServiceReward
    {
        public Task<RewardListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RewardDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RewardCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RewardUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RewardDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RewardCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RewardUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RewardDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}