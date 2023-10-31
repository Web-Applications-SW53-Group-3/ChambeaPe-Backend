using _3._Data.Model;

namespace _3._Data.Skills
{
    public interface ISkillData
    {
        Task<Skill> GetByIdAsync(int id);
        Task<List<Skill>> GetAllAsync();
        Task<bool> CreateAsync(Skill skill);
        Task<bool> UpdateAsync(Skill skill, int id);
        Task<bool> DeleteAsync(int id);
    }
}