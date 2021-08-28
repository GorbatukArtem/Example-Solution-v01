using System.Threading.Tasks;

namespace Logic.Administration.Security.Access
{
    public interface IServiceRequestStatus
    {
        Task<RequestStatusListVm> GetListAsync();
        Task<RequestStatusDetailsVm> GetDetailsAsync(int? id);

        Task<RequestStatusCreateVm> GetCreateAsync();
        Task<RequestStatusUpdateVm> GetUpdateAsync(int? id);
        Task<RequestStatusDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RequestStatusCreateVm view);
        Task UpdateAsync(RequestStatusUpdateVm view);
        Task DeleteAsync(RequestStatusDeleteVm view);
    }

    public class RequestStatusDeleteVm
    {
    }

    public class RequestStatusUpdateVm
    {
    }

    public class RequestStatusCreateVm
    {
    }

    public class RequestStatusDetailsVm
    {
    }

    public class RequestStatusListVm
    {
    }

    public class ServiceRequestStatus : IServiceRequestStatus
    {
        public Task<RequestStatusListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestStatusDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestStatusCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestStatusUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestStatusDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RequestStatusCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RequestStatusUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RequestStatusDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}