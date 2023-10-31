using _3._Data.Model;

namespace _2._Domain.Skills
{
    public interface ISkillDomain
    {
        Task<bool> CreateAsync(Skill skill, int workerId);
        Task<bool> UpdateAsync(Skill skill, int id);
        Task<bool> DeleteAsync(int id);
    }
}