using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgPositions
{
    public interface IServiceBackup
    {
        Task<BackupListVm> GetListAsync();
        Task<BackupDetailsVm> GetDetailsAsync(int? id);

        Task<BackupCreateVm> GetCreateAsync();
        Task<BackupUpdateVm> GetUpdateAsync(int? id);
        Task<BackupDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(BackupCreateVm view);
        Task UpdateAsync(BackupUpdateVm view);
        Task DeleteAsync(BackupDeleteVm view);
    }

    public class BackupDeleteVm
    {
    }

    public class BackupUpdateVm
    {
    }

    public class BackupCreateVm
    {
    }

    public class BackupDetailsVm
    {
    }

    public class BackupListVm
    {
    }

    public class ServiceBackup : IServiceBackup
    {
        public Task<BackupListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BackupDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<BackupCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BackupUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<BackupDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(BackupCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(BackupUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(BackupDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}