using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanMotivations
{
    public interface IServiceBonus
    {
        Task<BonusListVm> GetListAsync();
        Task<BonusDetailsVm> GetDetailsAsync(int? id);

        Task<BonusCreateVm> GetCreateAsync();
        Task<BonusUpdateVm> GetUpdateAsync(int? id);
        Task<BonusDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(BonusCreateVm view);
        Task UpdateAsync(BonusUpdateVm view);
        Task DeleteAsync(BonusDeleteVm view);
    }

    public class BonusDeleteVm
    {
    }

    public class BonusUpdateVm
    {
    }

    public class BonusCreateVm
    {
    }

    public class BonusDetailsVm
    {
    }

    public class BonusListVm
    {
    }

    public class ServiceBonus : IServiceBonus
    {
        public Task<BonusListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BonusDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<BonusCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BonusUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<BonusDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(BonusCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(BonusUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(BonusDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}