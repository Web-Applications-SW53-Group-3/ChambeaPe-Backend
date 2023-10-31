using _3._Data.Context;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Employers
{
    public class EmployerMySQLData : IEmployerData
    {
        private readonly ChambeaPeContext _context;
        public EmployerMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Employer>> GetAllAsync()
        {
            return await _context.Employers
                .Where(e => e.IsActive)
                .Include(e => e.User)
                .Include(e => e.Reviews)
                .ToListAsync();
        }

        public async Task<Employer> GetByIdAsync(int id)
        {
            return await _context.Employers
                .Where(e => e.IsActive && e.Id == id)
                .Include(e => e.User)
                .Include(e => e.Reviews)
                .FirstAsync();
        }

        public async Task<bool> CreateAsync(Employer employer)
        {
            try
            {
                await _context.Employers.AddAsync(employer);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Employer employer, int id)
        {
            try
            {
                employer.Id = id;
                employer.IsActive = true;
                employer.DateUpdated = DateTime.Now;
                _context.Employers.Update(employer);
                await _context.SaveChangesAsync();
                return true;
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
                var employerToBeDeleted = await _context.Employers.Where(e => e.IsActive && e.Id == id).FirstOrDefaultAsync();
                if (employerToBeDeleted != null)
                {
                    employerToBeDeleted.IsActive = false;
                    _context.Employers.Update(employerToBeDeleted);
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
