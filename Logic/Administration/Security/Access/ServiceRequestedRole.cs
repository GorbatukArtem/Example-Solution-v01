using System.Threading.Tasks;

namespace Logic.Administration.Security.Access
{
    public interface IServiceRequestedRole
    {
        Task<RequestedRoleListVm> GetListAsync();
        Task<RequestedRoleDetailsVm> GetDetailsAsync(int? id);

        Task<RequestedRoleCreateVm> GetCreateAsync();
        Task<RequestedRoleUpdateVm> GetUpdateAsync(int? id);
        Task<RequestedRoleDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RequestedRoleCreateVm view);
        Task UpdateAsync(RequestedRoleUpdateVm view);
        Task DeleteAsync(RequestedRoleDeleteVm view);
    }

    public class RequestedRoleDeleteVm
    {
    }

    public class RequestedRoleUpdateVm
    {
    }

    public class RequestedRoleCreateVm
    {
    }

    public class RequestedRoleDetailsVm
    {
    }

    public class RequestedRoleListVm
    {
    }

    public class ServiceRequestedRole : IServiceRequestedRole
    {
        public Task<RequestedRoleListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestedRoleDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestedRoleCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestedRoleUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestedRoleDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RequestedRoleCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RequestedRoleUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RequestedRoleDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}