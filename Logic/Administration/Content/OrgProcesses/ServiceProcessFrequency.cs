using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgProcesses
{
    public interface IServiceProcessFrequency
    {
        Task<ProcessFrequencyListVm> GetListAsync();
        Task<ProcessFrequencyDetailsVm> GetDetailsAsync(int? id);

        Task<ProcessFrequencyCreateVm> GetCreateAsync();
        Task<ProcessFrequencyUpdateVm> GetUpdateAsync(int? id);
        Task<ProcessFrequencyDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(ProcessFrequencyCreateVm view);
        Task UpdateAsync(ProcessFrequencyUpdateVm view);
        Task DeleteAsync(ProcessFrequencyDeleteVm view);
    }

    public class ProcessFrequencyDeleteVm
    {
    }

    public class ProcessFrequencyUpdateVm
    {
    }

    public class ProcessFrequencyCreateVm
    {
    }

    public class ProcessFrequencyDetailsVm
    {
    }

    public class ProcessFrequencyListVm
    {
    }

    public class ServiceProcessFrequency : IServiceProcessFrequency
    {
        public Task<ProcessFrequencyListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessFrequencyDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessFrequencyCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessFrequencyUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProcessFrequencyDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(ProcessFrequencyCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProcessFrequencyUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(ProcessFrequencyDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}