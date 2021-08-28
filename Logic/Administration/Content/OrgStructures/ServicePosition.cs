using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgStructures
{
    public interface IServicePosition
    {
        Task<PositionListVm> GetListAsync();
        Task<PositionDetailsVm> GetDetailsAsync(int? id);

        Task<PositionCreateVm> GetCreateAsync();
        Task<PositionUpdateVm> GetUpdateAsync(int? id);
        Task<PositionDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PositionCreateVm view);
        Task UpdateAsync(PositionUpdateVm view);
        Task DeleteAsync(PositionDeleteVm view);
    }

    public class PositionDeleteVm
    {
    }

    public class PositionUpdateVm
    {
    }

    public class PositionCreateVm
    {
    }

    public class PositionDetailsVm
    {
    }

    public class PositionListVm
    {
    }

    public class ServicePosition : IServicePosition
    {
        public Task<PositionListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PositionDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PositionCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PositionUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PositionDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PositionCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PositionUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PositionDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}