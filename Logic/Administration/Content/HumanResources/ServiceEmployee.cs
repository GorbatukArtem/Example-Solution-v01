using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanResources
{
    public interface IServiceEmployee
    {
        Task<EmployeeListVm> GetListAsync();
        Task<EmployeeDetailsVm> GetDetailsAsync(int? id);

        Task<EmployeeCreateVm> GetCreateAsync();
        Task<EmployeeUpdateVm> GetUpdateAsync(int? id);
        Task<EmployeeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(EmployeeCreateVm view);
        Task UpdateAsync(EmployeeUpdateVm view);
        Task DeleteAsync(EmployeeDeleteVm view);
    }

    public class EmployeeDeleteVm
    {
    }

    public class EmployeeUpdateVm
    {
    }

    public class EmployeeCreateVm
    {
    }

    public class EmployeeDetailsVm
    {
    }

    public class EmployeeListVm
    {
    }

    public class ServiceEmployee : IServiceEmployee
    {
        public Task<EmployeeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(EmployeeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(EmployeeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(EmployeeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}