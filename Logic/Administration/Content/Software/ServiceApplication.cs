using System.Threading.Tasks;

namespace Logic.Administration.Content.Software
{
    public interface IServiceApplication
    {
        Task<ApplicationListVm> GetListAsync();
        Task<ApplicationDetailsVm> GetDetailsAsync(int? id);

        Task<ApplicationCreateVm> GetCreateAsync();
        Task<ApplicationUpdateVm> GetUpdateAsync(int? id);
        Task<ApplicationDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(ApplicationCreateVm view);
        Task UpdateAsync(ApplicationUpdateVm view);
        Task DeleteAsync(ApplicationDeleteVm view);
    }

    public class ApplicationDeleteVm
    {
    }

    public class ApplicationUpdateVm
    {
    }

    public class ApplicationCreateVm
    {
    }

    public class ApplicationDetailsVm
    {
    }

    public class ApplicationListVm
    {
    }

    public class ServiceApplication : IServiceApplication
    {
        public Task<ApplicationListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ApplicationDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ApplicationCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ApplicationUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ApplicationDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(ApplicationCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(ApplicationDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}