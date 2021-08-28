using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourSafety
{
    public interface IServiceIncidentTypeType
    {
        Task<IncidentTypeListVm> GetListAsync();
        Task<IncidentTypeDetailsVm> GetDetailsAsync(int? id);

        Task<IncidentTypeCreateVm> GetCreateAsync();
        Task<IncidentTypeUpdateVm> GetUpdateAsync(int? id);
        Task<IncidentTypeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(IncidentTypeCreateVm view);
        Task UpdateAsync(IncidentTypeUpdateVm view);
        Task DeleteAsync(IncidentTypeDeleteVm view);
    }

    public class IncidentTypeDeleteVm
    {
    }

    public class IncidentTypeUpdateVm
    {
    }

    public class IncidentTypeCreateVm
    {
    }

    public class IncidentTypeDetailsVm
    {
    }

    public class IncidentTypeListVm
    {
    }

    public class ServiceIncidentTypeType : IServiceIncidentTypeType
    {
        public Task<IncidentTypeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentTypeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentTypeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentTypeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentTypeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(IncidentTypeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(IncidentTypeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(IncidentTypeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}