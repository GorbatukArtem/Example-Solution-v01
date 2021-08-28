using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanEducations
{
    public interface IServiceTraining
    {
        Task<TrainingListVm> GetListAsync();
        Task<TrainingDetailsVm> GetDetailsAsync(int? id);

        Task<TrainingCreateVm> GetCreateAsync();
        Task<TrainingUpdateVm> GetUpdateAsync(int? id);
        Task<TrainingDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(TrainingCreateVm view);
        Task UpdateAsync(TrainingUpdateVm view);
        Task DeleteAsync(TrainingDeleteVm view);
    }

    public class TrainingDeleteVm
    {
    }

    public class TrainingUpdateVm
    {
    }

    public class TrainingCreateVm
    {
    }

    public class TrainingDetailsVm
    {
    }

    public class TrainingListVm
    {
    }

    public class ServiceTraining : IServiceTraining
    {
        public Task<TrainingListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TrainingDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TrainingCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TrainingUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TrainingDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(TrainingCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(TrainingUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(TrainingDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}