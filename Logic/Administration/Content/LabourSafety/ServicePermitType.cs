using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourSafety
{
    public interface IServicePermitType
    {
        Task<PermitTypeListVm> GetListAsync();
        Task<PermitTypeDetailsVm> GetDetailsAsync(int? id);

        Task<PermitTypeCreateVm> GetCreateAsync();
        Task<PermitTypeUpdateVm> GetUpdateAsync(int? id);
        Task<PermitTypeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PermitTypeCreateVm view);
        Task UpdateAsync(PermitTypeUpdateVm view);
        Task DeleteAsync(PermitTypeDeleteVm view);
    }

    public class PermitTypeDeleteVm
    {
    }

    public class PermitTypeUpdateVm
    {
    }

    public class PermitTypeCreateVm
    {
    }

    public class PermitTypeDetailsVm
    {
    }

    public class PermitTypeListVm
    {
    }

    public class ServicePermitType : IServicePermitType
    {
        public Task<PermitTypeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitTypeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitTypeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitTypeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitTypeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PermitTypeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PermitTypeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PermitTypeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}