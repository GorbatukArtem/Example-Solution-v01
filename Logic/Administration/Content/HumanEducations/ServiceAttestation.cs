using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanEducations
{
    public interface IServiceAttestation
    {
        Task<AttestationListVm> GetListAsync();
        Task<AttestationDetailsVm> GetDetailsAsync(int? id);

        Task<AttestationCreateVm> GetCreateAsync();
        Task<AttestationUpdateVm> GetUpdateAsync(int? id);
        Task<AttestationDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(AttestationCreateVm view);
        Task UpdateAsync(AttestationUpdateVm view);
        Task DeleteAsync(AttestationDeleteVm view);
    }

    public class AttestationDeleteVm
    {
    }

    public class AttestationUpdateVm
    {
    }

    public class AttestationCreateVm
    {
    }

    public class AttestationDetailsVm
    {
    }

    public class AttestationListVm
    {
    }

    public class ServiceAttestation : IServiceAttestation
    {
        public Task<AttestationListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AttestationDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AttestationCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AttestationUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AttestationDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(AttestationCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(AttestationUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AttestationDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}