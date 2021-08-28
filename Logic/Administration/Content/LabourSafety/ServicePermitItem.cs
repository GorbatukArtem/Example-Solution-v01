using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourSafety
{
    public interface IServicePermitItemItem
    {
        Task<PermitItemListVm> GetListAsync();
        Task<PermitItemDetailsVm> GetDetailsAsync(int? id);

        Task<PermitItemCreateVm> GetCreateAsync();
        Task<PermitItemUpdateVm> GetUpdateAsync(int? id);
        Task<PermitItemDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PermitItemCreateVm view);
        Task UpdateAsync(PermitItemUpdateVm view);
        Task DeleteAsync(PermitItemDeleteVm view);
    }

    public class PermitItemDeleteVm
    {
    }

    public class PermitItemUpdateVm
    {
    }

    public class PermitItemCreateVm
    {
    }

    public class PermitItemDetailsVm
    {
    }

    public class PermitItemListVm
    {
    }

    public class ServicePermitItemItem : IServicePermitItemItem
    {
        public Task<PermitItemListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitItemDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitItemCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitItemUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PermitItemDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PermitItemCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PermitItemUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PermitItemDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}