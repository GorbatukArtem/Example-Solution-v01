using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgPositions
{
    public interface IServiceAccess
    {
        Task<AccessListVm> GetListAsync();
        Task<AccessDetailsVm> GetDetailsAsync(int? id);

        Task<AccessCreateVm> GetCreateAsync();
        Task<AccessUpdateVm> GetUpdateAsync(int? id);
        Task<AccessDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(AccessCreateVm view);
        Task UpdateAsync(AccessUpdateVm view);
        Task DeleteAsync(AccessDeleteVm view);
    }

    public class AccessDeleteVm
    {
    }

    public class AccessUpdateVm
    {
    }

    public class AccessCreateVm
    {
    }

    public class AccessDetailsVm
    {
    }

    public class AccessListVm
    {
    }

    public class ServiceAccess : IServiceAccess
    {
        public Task<AccessListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AccessDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AccessCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AccessUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AccessDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(AccessCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(AccessUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AccessDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}