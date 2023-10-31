using _3._Data.Model;
using _3._Data.Context;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Skills
{
    public class SkillMySQLData : ISkillData
    {
        private ChambeaPeContext _context;

        public SkillMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Skill>> GetAllAsync()
        {
            return await _context.Skills.Where(s => s.IsActive).ToListAsync();
        }

        public async Task<Skill> GetByIdAsync(int id)
        {
            return await _context.Skills.Where(s => s.IsActive).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> CreateAsync(Skill skill)
        {
            try
            {
                await _context.Skills.AddAsync(skill);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Skill skill, int id)
        {
            try
            {
                var skillToBeUpdated = await _context.Skills.FirstOrDefaultAsync(s => s.Id == id);
                if (skillToBeUpdated != null)
                {
                    skillToBeUpdated.Content = skill.Content;
                    skillToBeUpdated.DateUpdated = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var skillToBeDeleted = await _context.Skills.FirstOrDefaultAsync(s => s.Id == id);
                if (skillToBeDeleted != null)
                {
                    skillToBeDeleted.IsActive = false;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
