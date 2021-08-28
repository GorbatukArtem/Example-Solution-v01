using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgPositions
{
    public interface IServiceProcess
    {
        Task<ProcessListVm> GetListAsync();
        Task<ProcessDetailsVm> GetDetailsAsync(int? id);

        Task<ProcessCreateVm> GetCreateAsync();
        Task<ProcessUpdateVm> GetUpdateAsync(int? id);
        Task<ProcessDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(ProcessCreateVm view);
        Task UpdateAsync(ProcessUpdateVm view);
        Task DeleteAsync(ProcessDeleteVm view);
    }

    public class ProcessDeleteVm
    {
    }

    public class ProcessUpdateVm
    {
    }

    public class ProcessCreateVm
    {
    }

    public class ProcessDetailsVm
    {
    }

    public class ProcessListVm
    {
    }

    public class ServiceProcess : IServiceProcess
    {
        public Task<ProcessListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(ProcessCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProcessUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(ProcessDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}