using System;
using System.Threading.Tasks;

namespace Logic.Administration.Logs
{
    public interface IServiceHistoryError
    {

        Task<HistoryErrorListVm> GetListAsync();
        Task<HistoryErrorDetailsVm> GetDetailsAsync(int? id);

        Task<HistoryErrorCreateVm> GetCreateAsync();
        Task<HistoryErrorUpdateVm> GetUpdateAsync(int? id);
        Task<HistoryErrorDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(HistoryErrorCreateVm view);
        Task UpdateAsync(HistoryErrorUpdateVm view);
        Task DeleteAsync(HistoryErrorDeleteVm view);
    }

    public class HistoryErrorDeleteVm
    {


    }

    public class HistoryErrorUpdateVm
    {
    }

    public class HistoryErrorCreateVm
    {
    }

    public class HistoryErrorDetailsVm
    {
    }

    public class HistoryErrorListVm
    {
    }

    public class ServiceHistoryError : IServiceHistoryError
    {
        public Task<HistoryErrorListVm> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HistoryErrorDetailsVm> GetDetailsAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<HistoryErrorCreateVm> GetCreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HistoryErrorUpdateVm> GetUpdateAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<HistoryErrorDeleteVm> GetDeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(HistoryErrorCreateVm view)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(HistoryErrorUpdateVm view)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(HistoryErrorDeleteVm view)
        {
            throw new NotImplementedException();
        }
    }
}