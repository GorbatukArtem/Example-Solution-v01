using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanContacts
{
    public interface IServiceEmail
    {
        Task<EmailListVm> GetListAsync();
        Task<EmailDetailsVm> GetDetailsAsync(int? id);

        Task<EmailCreateVm> GetCreateAsync();
        Task<EmailUpdateVm> GetUpdateAsync(int? id);
        Task<EmailDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(EmailCreateVm view);
        Task UpdateAsync(EmailUpdateVm view);
        Task DeleteAsync(EmailDeleteVm view);
    }

    public class ServiceEmail : IServiceEmail
    {
        public Task<EmailListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmailDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(EmailCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(EmailUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(EmailDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class EmailDeleteVm
    {
    }

    public class EmailUpdateVm
    {
    }

    public class EmailCreateVm
    {
    }

    public class EmailDetailsVm
    {
    }

    public class EmailListVm
    {
    }
}