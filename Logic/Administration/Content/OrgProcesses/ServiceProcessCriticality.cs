using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgProcesses
{
    public interface IServiceProcessCriticality
    {
        Task<ProcessCriticalityListVm> GetListAsync();
        Task<ProcessCriticalityDetailsVm> GetDetailsAsync(int? id);

        Task<ProcessCriticalityCreateVm> GetCreateAsync();
        Task<ProcessCriticalityUpdateVm> GetUpdateAsync(int? id);
        Task<ProcessCriticalityDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(ProcessCriticalityCreateVm view);
        Task UpdateAsync(ProcessCriticalityUpdateVm view);
        Task DeleteAsync(ProcessCriticalityDeleteVm view);
    }

    public class ProcessCriticalityDeleteVm
    {
    }

    public class ProcessCriticalityUpdateVm
    {
    }

    public class ProcessCriticalityCreateVm
    {
    }

    public class ProcessCriticalityDetailsVm
    {
    }

    public class ProcessCriticalityListVm
    {
    }

    public class ServiceProcessCriticality : IServiceProcessCriticality
    {
        public Task<ProcessCriticalityListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessCriticalityDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessCriticalityCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessCriticalityUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessCriticalityDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(ProcessCriticalityCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProcessCriticalityUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(ProcessCriticalityDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}