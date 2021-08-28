using System.Threading.Tasks;

namespace Logic.Administration.Content.LabourPerformance
{
    public interface IServiceTask
    {
        Task<TaskListVm> GetListAsync();
        Task<TaskDetailsVm> GetDetailsAsync(int? id);

        Task<TaskCreateVm> GetCreateAsync();
        Task<TaskUpdateVm> GetUpdateAsync(int? id);
        Task<TaskDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(TaskCreateVm view);
        Task UpdateAsync(TaskUpdateVm view);
        Task DeleteAsync(TaskDeleteVm view);
    }

    public class TaskDeleteVm
    {
    }

    public class TaskUpdateVm
    {
    }

    public class TaskCreateVm
    {
    }

    public class TaskDetailsVm
    {
    }

    public class TaskListVm
    {
    }

    public class ServiceTask : IServiceTask
    {
        public Task<TaskListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(TaskCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(TaskUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(TaskDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}