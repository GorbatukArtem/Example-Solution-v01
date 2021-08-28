using System.Threading.Tasks;

namespace Logic.Administration.Security.Access
{
    public interface IServiceRequest
    {
        Task<RequestListVm> GetListAsync();
        Task<RequestDetailsVm> GetDetailsAsync(int? id);

        Task<RequestCreateVm> GetCreateAsync();
        Task<RequestUpdateVm> GetUpdateAsync(int? id);
        Task<RequestDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RequestCreateVm view);
        Task UpdateAsync(RequestUpdateVm view);
        Task DeleteAsync(RequestDeleteVm view);
    }

    public class RequestDeleteVm
    {
    }

    public class RequestUpdateVm
    {
    }

    public class RequestCreateVm
    {
    }

    public class RequestDetailsVm
    {
    }

    public class RequestListVm
    {
    }

    public class ServiceRequest : IServiceRequest
    {
        public Task<RequestListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RequestCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RequestUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RequestDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}