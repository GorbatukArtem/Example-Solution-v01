using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgPositions
{
    public interface IServiceAssignment
    {
        Task<AssignmentListVm> GetListAsync();
        Task<AssignmentDetailsVm> GetDetailsAsync(int? id);

        Task<AssignmentCreateVm> GetCreateAsync();
        Task<AssignmentUpdateVm> GetUpdateAsync(int? id);
        Task<AssignmentDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(AssignmentCreateVm view);
        Task UpdateAsync(AssignmentUpdateVm view);
        Task DeleteAsync(AssignmentDeleteVm view);
    }

    public class AssignmentDeleteVm
    {
    }

    public class AssignmentUpdateVm
    {
    }

    public class AssignmentCreateVm
    {
    }

    public class AssignmentDetailsVm
    {
    }

    public class AssignmentListVm
    {
    }

    public class ServiceAssignment : IServiceAssignment
    {
        public Task<AssignmentListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AssignmentDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AssignmentCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AssignmentUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AssignmentDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(AssignmentCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(AssignmentUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AssignmentDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}