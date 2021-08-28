using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgStructures
{
    public interface IServiceDepartment
    {
        Task<DepartmentListVm> GetListAsync();
        Task<DepartmentDetailsVm> GetDetailsAsync(int? id);

        Task<DepartmentCreateVm> GetCreateAsync();
        Task<DepartmentUpdateVm> GetUpdateAsync(int? id);
        Task<DepartmentDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(DepartmentCreateVm view);
        Task UpdateAsync(DepartmentUpdateVm view);
        Task DeleteAsync(DepartmentDeleteVm view);
    }

    public class DepartmentDeleteVm
    {
    }

    public class DepartmentUpdateVm
    {
    }

    public class DepartmentCreateVm
    {
    }

    public class DepartmentDetailsVm
    {
    }

    public class DepartmentListVm
    {
    }

    public class ServiceDepartment : IServiceDepartment
    {
        public Task<DepartmentListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<DepartmentDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DepartmentCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<DepartmentUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DepartmentDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(DepartmentCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(DepartmentUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(DepartmentDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}