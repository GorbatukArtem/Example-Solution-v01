using Logic.Administration.Content.OrgPositions;
using System.Threading.Tasks;

namespace Logic.Administration.Security.Authorization
{
    public interface IServiceRole
    {
        Task<RoleListVm> GetListAsync();
        Task<RoleDetailsVm> GetDetailsAsync(int? id);

        Task<RoleCreateVm> GetCreateAsync();
        Task<RoleUpdateVm> GetUpdateAsync(int? id);
        Task<RoleDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(RoleCreateVm view);
        Task UpdateAsync(RoleUpdateVm view);
        Task DeleteAsync(RoleDeleteVm view);
    }

    public class RoleDeleteVm
    {
    }

    public class RoleUpdateVm
    {
    }

    public class RoleCreateVm
    {
    }

    public class RoleDetailsVm
    {
    }

    public class RoleListVm
    {
    }

    public class ServiceRole : IServiceRole
    {
        public Task<RoleListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RoleDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RoleCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<RoleUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RoleDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(RoleCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(RoleUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(RoleDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}