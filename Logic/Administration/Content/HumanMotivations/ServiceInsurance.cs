using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanMotivations
{
    public interface IServiceInsurance
    {
        Task<InsuranceListVm> GetListAsync();
        Task<InsuranceDetailsVm> GetDetailsAsync(int? id);

        Task<InsuranceCreateVm> GetCreateAsync();
        Task<InsuranceUpdateVm> GetUpdateAsync(int? id);
        Task<InsuranceDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(InsuranceCreateVm view);
        Task UpdateAsync(InsuranceUpdateVm view);
        Task DeleteAsync(InsuranceDeleteVm view);
    }

    public class InsuranceDeleteVm
    {
    }

    public class InsuranceUpdateVm
    {
    }

    public class InsuranceCreateVm
    {
    }

    public class InsuranceDetailsVm
    {
    }

    public class InsuranceListVm
    {
    }

    public class ServiceInsurance : IServiceInsurance
    {
        public Task<InsuranceListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<InsuranceDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<InsuranceCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<InsuranceUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<InsuranceDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(InsuranceCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(InsuranceUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(InsuranceDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}