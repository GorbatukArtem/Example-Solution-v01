using Logic.Administration.Content.OrgPositions;
using System.Threading.Tasks;

namespace Logic.Administration.Security.Authorization
{
    public interface IServicePermission
    {
        Task<PermissionListVm> GetListAsync();
        Task<PermissionDetailsVm> GetDetailsAsync(int? id);

        Task<PermissionCreateVm> GetCreateAsync();
        Task<PermissionUpdateVm> GetUpdateAsync(int? id);
        Task<PermissionDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PermissionCreateVm view);
        Task UpdateAsync(PermissionUpdateVm view);
        Task DeleteAsync(PermissionDeleteVm view);
    }

    public class PermissionDeleteVm
    {
    }

    public class PermissionUpdateVm
    {
    }

    public class PermissionCreateVm
    {
    }

    public class PermissionDetailsVm
    {
    }

    public class PermissionListVm
    {
    }

    public class ServicePermission : IServicePermission
    {
        public Task<PermissionListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermissionDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermissionCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermissionUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermissionDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PermissionCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PermissionUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PermissionDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}