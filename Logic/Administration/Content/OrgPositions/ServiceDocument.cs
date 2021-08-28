using System.Threading.Tasks;

namespace Logic.Administration.Content.OrgPositions
{
    public interface IServiceDocument
    {
        Task<DocumentListVm> GetListAsync();
        Task<DocumentDetailsVm> GetDetailsAsync(int? id);

        Task<DocumentCreateVm> GetCreateAsync();
        Task<DocumentUpdateVm> GetUpdateAsync(int? id);
        Task<DocumentDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(DocumentCreateVm view);
        Task UpdateAsync(DocumentUpdateVm view);
        Task DeleteAsync(DocumentDeleteVm view);
    }

    public class DocumentDeleteVm
    {
    }

    public class DocumentUpdateVm
    {
    }

    public class DocumentCreateVm
    {
    }

    public class DocumentDetailsVm
    {
    }

    public class DocumentListVm
    {
    }

    public class ServiceDocument : IServiceDocument
    {
        public Task<DocumentListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<DocumentDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DocumentCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<DocumentUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DocumentDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(DocumentCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(DocumentUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(DocumentDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}