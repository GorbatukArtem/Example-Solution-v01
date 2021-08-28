using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanResources
{
    public interface IServiceVacation
    {
        Task<VacationListVm> GetListAsync();
        Task<VacationDetailsVm> GetDetailsAsync(int? id);

        Task<VacationCreateVm> GetCreateAsync();
        Task<VacationUpdateVm> GetUpdateAsync(int? id);
        Task<VacationDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(VacationCreateVm view);
        Task UpdateAsync(VacationUpdateVm view);
        Task DeleteAsync(VacationDeleteVm view);
    }

    public class VacationDeleteVm
    {
    }

    public class VacationUpdateVm
    {
    }

    public class VacationCreateVm
    {
    }

    public class VacationDetailsVm
    {
    }

    public class VacationListVm
    {
    }

    public class ServiceVacation : IServiceVacation
    {
        public Task<VacationListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(VacationCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(VacationUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(VacationDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}