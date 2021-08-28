using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourSafety
{
    public interface IServicePermit
    {
        Task<PermitListVm> GetListAsync();
        Task<PermitDetailsVm> GetDetailsAsync(int? id);

        Task<PermitCreateVm> GetCreateAsync();
        Task<PermitUpdateVm> GetUpdateAsync(int? id);
        Task<PermitDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PermitCreateVm view);
        Task UpdateAsync(PermitUpdateVm view);
        Task DeleteAsync(PermitDeleteVm view);
    }

    public class PermitDeleteVm
    {
    }

    public class PermitUpdateVm
    {
    }

    public class PermitCreateVm
    {
    }

    public class PermitDetailsVm
    {
    }

    public class PermitListVm
    {
    }

    public class ServicePermit : IServicePermit
    {
        public Task<PermitListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PermitCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PermitUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PermitDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}