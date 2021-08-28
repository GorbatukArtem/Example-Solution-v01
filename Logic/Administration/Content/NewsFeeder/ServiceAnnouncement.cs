using System.Threading.Tasks;

namespace Logic.Administration.Content.NewsFeeder
{
    public interface IServiceAnnouncement
    {
        Task<AnnouncementListVm> GetListAsync();
        Task<AnnouncementDetailsVm> GetDetailsAsync(int? id);

        Task<AnnouncementCreateVm> GetCreateAsync();
        Task<AnnouncementUpdateVm> GetUpdateAsync(int? id);
        Task<AnnouncementDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(AnnouncementCreateVm view);
        Task UpdateAsync(AnnouncementUpdateVm view);
        Task DeleteAsync(AnnouncementDeleteVm view);
    }

    public class AnnouncementDeleteVm
    {
    }

    public class AnnouncementUpdateVm
    {
    }

    public class AnnouncementCreateVm
    {
    }

    public class AnnouncementDetailsVm
    {
    }

    public class AnnouncementListVm
    {
    }

    public class ServiceAnnouncement : IServiceAnnouncement
    {
        public Task<AnnouncementListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AnnouncementDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AnnouncementCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<AnnouncementUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AnnouncementDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(AnnouncementCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(AnnouncementUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AnnouncementDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}