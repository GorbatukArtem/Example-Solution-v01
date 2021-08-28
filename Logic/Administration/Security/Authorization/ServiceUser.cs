using System.Threading.Tasks;

namespace Logic.Administration.Security.Authorization
{
    public interface IServiceUser
    {
        Task<UserListVm> GetListAsync();
        Task<UserDetailsVm> GetDetailsAsync(int? id);

        Task<UserCreateVm> GetCreateAsync();
        Task<UserUpdateVm> GetUpdateAsync(int? id);
        Task<UserDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(UserCreateVm view);
        Task UpdateAsync(UserUpdateVm view);
        Task DeleteAsync(UserDeleteVm view);
    }

    public class UserDeleteVm
    {
    }

    public class UserUpdateVm
    {
    }

    public class UserCreateVm
    {
    }

    public class UserDetailsVm
    {
    }

    public class UserListVm
    {
    }

    public class ServiceUser : IServiceUser
    {
        public Task<UserListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(UserCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(UserUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(UserDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}