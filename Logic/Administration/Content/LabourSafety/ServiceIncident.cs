using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourSafety
{
    public interface IServiceIncident
    {
        Task<IncidentListVm> GetListAsync();
        Task<IncidentDetailsVm> GetDetailsAsync(int? id);

        Task<IncidentCreateVm> GetCreateAsync();
        Task<IncidentUpdateVm> GetUpdateAsync(int? id);
        Task<IncidentDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(IncidentCreateVm view);
        Task UpdateAsync(IncidentUpdateVm view);
        Task DeleteAsync(IncidentDeleteVm view);
    }

    public class IncidentDeleteVm
    {
    }

    public class IncidentUpdateVm
    {
    }

    public class IncidentCreateVm
    {
    }

    public class IncidentDetailsVm
    {
    }

    public class IncidentListVm
    {
    }

    public class ServiceIncident : IServiceIncident
    {
        public Task<IncidentListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IncidentDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(IncidentCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(IncidentUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(IncidentDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}