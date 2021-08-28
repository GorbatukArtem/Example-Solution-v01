using System.Threading.Tasks;

namespace Logic.Administration.Content.HumanEducations
{
    public interface IServiceSkill
    {
        Task<SkillListVm> GetListAsync();
        Task<SkillDetailsVm> GetDetailsAsync(int? id);

        Task<SkillCreateVm> GetCreateAsync();
        Task<SkillUpdateVm> GetUpdateAsync(int? id);
        Task<SkillDeleteVm> GetDeleteAsync(int? id);

        Task CreateAsync(SkillCreateVm view);
        Task UpdateAsync(SkillUpdateVm view);
        Task DeleteAsync(SkillDeleteVm view);
    }

    public class SkillDeleteVm
    {
    }

    public class SkillUpdateVm
    {
    }

    public class SkillCreateVm
    {
    }

    public class SkillDetailsVm
    {
    }

    public class SkillListVm
    {
    }

    public class ServiceSkill : IServiceSkill
    {
        public Task<SkillListVm> GetListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<SkillDetailsVm> GetDetailsAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkillCreateVm> GetCreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<SkillUpdateVm> GetUpdateAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkillDeleteVm> GetDeleteAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(SkillCreateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(SkillUpdateVm view)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(SkillDeleteVm view)
        {
            throw new System.NotImplementedException();
        }
    }
}