using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgStructures
{
    public interface IServiceCompany
    {
        Task<CompanyListVm> GetListAsync();
        Task<CompanyDetailsVm> GetDetailsAsync(int? id);

        Task<CompanyCreateVm> GetCreateAsync();
        Task<CompanyUpdateVm> GetUpdateAsync(int? id);
        Task<CompanyDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(CompanyCreateVm view);
        Task UpdateAsync(CompanyUpdateVm view);
        Task DeleteAsync(CompanyDeleteVm view);
    }

    public class CompanyDeleteVm
    {
    }

    public class CompanyUpdateVm
    {
    }

    public class CompanyCreateVm
    {
    }

    public class CompanyDetailsVm
    {
    }

    public class CompanyListVm
    {
    }

    public class ServiceCompany : IServiceCompany
    {
        public Task<CompanyListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<CompanyDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CompanyCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<CompanyUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<CompanyDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(CompanyCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(CompanyUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(CompanyDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}