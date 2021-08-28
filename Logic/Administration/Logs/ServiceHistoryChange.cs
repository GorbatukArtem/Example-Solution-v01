using System.Threading.Tasks;

namespace Logic.Administration.Logs
{
    public interface IServiceHistoryChange
    {
        Task<HistoryChangeListVm> GetListAsync();
        Task<HistoryChangeDetailsVm> GetDetailsAsync(int? id);

        Task<HistoryChangeCreateVm> GetCreateAsync();
        Task<HistoryChangeUpdateVm> GetUpdateAsync(int? id);
        Task<HistoryChangeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(HistoryChangeCreateVm view);
        Task UpdateAsync(HistoryChangeUpdateVm view);
        Task DeleteAsync(HistoryChangeDeleteVm view);
    }

    public class HistoryChangeDeleteVm
    {
    }

    public class HistoryChangeUpdateVm
    {
    }

    public class HistoryChangeCreateVm
    {
    }

    public class HistoryChangeDetailsVm
    {
    }

    public class HistoryChangeListVm
    {
    }

    public class ServiceHistoryChange : IServiceHistoryChange
    {
        public Task<HistoryChangeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryChangeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryChangeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryChangeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryChangeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(HistoryChangeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(HistoryChangeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(HistoryChangeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}