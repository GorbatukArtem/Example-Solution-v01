using System.Threading.Tasks;

namespace Logic.Administration.Logs
{
    public interface IServiceHistoryLogin
    {
        Task<HistoryLoginListVm> GetListAsync();
        Task<HistoryLoginDetailsVm> GetDetailsAsync(int? id);

        Task<HistoryLoginCreateVm> GetCreateAsync();
        Task<HistoryLoginUpdateVm> GetUpdateAsync(int? id);
        Task<HistoryLoginDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(HistoryLoginCreateVm view);
        Task UpdateAsync(HistoryLoginUpdateVm view);
        Task DeleteAsync(HistoryLoginDeleteVm view);
    }

    public class HistoryLoginDeleteVm
    {
    }

    public class HistoryLoginUpdateVm
    {
    }

    public class HistoryLoginCreateVm
    {
    }

    public class HistoryLoginDetailsVm
    {
    }

    public class HistoryLoginListVm
    {
    }

    public class ServiceHistoryLogin : IServiceHistoryLogin
    {
        public Task<HistoryLoginListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryLoginDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryLoginCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryLoginUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<HistoryLoginDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(HistoryLoginCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(HistoryLoginUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(HistoryLoginDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}