using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgProcesses
{
    public interface IServiceProcessComplexity
    {
        Task<ProcessComplexityListVm> GetListAsync();
        Task<ProcessComplexityDetailsVm> GetDetailsAsync(int? id);

        Task<ProcessComplexityCreateVm> GetCreateAsync();
        Task<ProcessComplexityUpdateVm> GetUpdateAsync(int? id);
        Task<ProcessComplexityDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(ProcessComplexityCreateVm view);
        Task UpdateAsync(ProcessComplexityUpdateVm view);
        Task DeleteAsync(ProcessComplexityDeleteVm view);
    }
    
    public class ProcessComplexityDeleteVm
    {
    }

    public class ProcessComplexityUpdateVm
    {
    }

    public class ProcessComplexityCreateVm
    {
    }

    public class ProcessComplexityDetailsVm
    {
    }

    public class ProcessComplexityListVm
    {
    }

    public class ServiceProcessComplexity : IServiceProcessComplexity
    {
        public Task<ProcessComplexityListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessComplexityDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessComplexityCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessComplexityUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessComplexityDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(ProcessComplexityCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProcessComplexityUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(ProcessComplexityDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}