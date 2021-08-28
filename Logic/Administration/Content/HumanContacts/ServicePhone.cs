using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanContacts
{
    public interface IServicePhone
    {
        Task<PhoneListVm> GetListAsync();
        Task<PhoneDetailsVm> GetDetailsAsync(int? id);

        Task<PhoneCreateVm> GetCreateAsync();
        Task<PhoneUpdateVm> GetUpdateAsync(int? id);
        Task<PhoneDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(PhoneCreateVm view);
        Task UpdateAsync(PhoneUpdateVm view);
        Task DeleteAsync(PhoneDeleteVm view);
    }

    public class PhoneDeleteVm
    {
    }

    public class PhoneUpdateVm
    {
    }

    public class PhoneCreateVm
    {
    }

    public class PhoneDetailsVm
    {
    }

    public class PhoneListVm
    {
    }

    public class ServicePhone : IServicePhone
    {
        public Task<PhoneListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PhoneDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PhoneCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<PhoneUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PhoneDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(PhoneCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(PhoneUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(PhoneDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}