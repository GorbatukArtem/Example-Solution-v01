using System.Threading.Tasks;

namespace Logic.Administration.Security.Access
{
    public interface IServiceRequestType
    {
        Task<RequestTypeListVm> GetListAsync();
        Task<RequestTypeDetailsVm> GetDetailsAsync(int? id);

        Task<RequestTypeCreateVm> GetCreateAsync();
        Task<RequestTypeUpdateVm> GetUpdateAsync(int? id);
        Task<RequestTypeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RequestTypeCreateVm view);
        Task UpdateAsync(RequestTypeUpdateVm view);
        Task DeleteAsync(RequestTypeDeleteVm view);
    }

    public class RequestTypeDeleteVm
    {
    }

    public class RequestTypeUpdateVm
    {
    }

    public class RequestTypeCreateVm
    {
    }

    public class RequestTypeDetailsVm
    {
    }

    public class RequestTypeListVm
    {
    }

    public class ServiceRequestType : IServiceRequestType
    {
        public Task<RequestTypeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestTypeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestTypeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestTypeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestTypeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RequestTypeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RequestTypeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RequestTypeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}