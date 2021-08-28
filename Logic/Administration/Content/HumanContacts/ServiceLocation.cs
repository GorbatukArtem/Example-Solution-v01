using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanContacts
{
    public interface IServiceLocation
    {
        Task<LocationListVm> GetListAsync();
        Task<LocationDetailsVm> GetDetailsAsync(int? id);

        Task<LocationCreateVm> GetCreateAsync();
        Task<LocationUpdateVm> GetUpdateAsync(int? id);
        Task<LocationDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(LocationCreateVm view);
        Task UpdateAsync(LocationUpdateVm view);
        Task DeleteAsync(LocationDeleteVm view);
    }

    public class LocationDeleteVm
    {
    }

    public class LocationUpdateVm
    {
    }

    public class LocationCreateVm
    {
    }

    public class LocationDetailsVm
    {
    }

    public class LocationListVm
    {
    }

    public class ServiceLocation : IServiceLocation
    {
        public Task<LocationListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(LocationCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(LocationUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(LocationDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}