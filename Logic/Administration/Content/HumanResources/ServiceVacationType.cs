using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanResources
{
    public interface IServiceVacationTypeType
    {
        Task<VacationTypeListVm> GetListAsync();
        Task<VacationTypeDetailsVm> GetDetailsAsync(int? id);

        Task<VacationTypeCreateVm> GetCreateAsync();
        Task<VacationTypeUpdateVm> GetUpdateAsync(int? id);
        Task<VacationTypeDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(VacationTypeCreateVm view);
        Task UpdateAsync(VacationTypeUpdateVm view);
        Task DeleteAsync(VacationTypeDeleteVm view);
    }

    public class VacationTypeDeleteVm
    {
    }

    public class VacationTypeUpdateVm
    {
    }

    public class VacationTypeCreateVm
    {
    }

    public class VacationTypeDetailsVm
    {
    }

    public class VacationTypeListVm
    {
    }

    public class ServiceVacationTypeType : IServiceVacationTypeType
    {
        public Task<VacationTypeListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationTypeDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationTypeCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationTypeUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<VacationTypeDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(VacationTypeCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(VacationTypeUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(VacationTypeDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}