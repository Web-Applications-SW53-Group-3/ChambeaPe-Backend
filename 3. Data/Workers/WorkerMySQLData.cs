using _3._Data.Model;
using _3._Data.Context;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Workers
{
    public class WorkerMySQLData : IWorkerData
    {
        private ChambeaPeContext _context;
        public WorkerMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }
        public async Task<List<Worker>> GetAllAsync()
        {
            return await _context.Workers
                .Where(w => w.IsActive)
                .Include(w => w.User)
                .Include(w => w.Certificates)
                .Include(w => w.Skills)
                .Include(w => w.Portfolios)
                .Include(w => w.Reviews)
                .ToListAsync();
        }

        public async Task<Worker?> ExistsByIdAsync(int id)
        {
            return await _context.Workers.FindAsync(id);
        }

        public async Task<Worker> GetByIdAsync(int id)
        {
            return await _context.Workers
                .Where(w => w.IsActive && w.Id == id)
                .Where(w => w.IsActive)
                .Include(w => w.User)
                .Include(w => w.Certificates)
                .Include(w => w.Skills)
                .Include(w => w.Portfolios)
                .Include(w => w.Reviews)
                .FirstAsync();
        }

        public async Task<bool> CreateAsync(Worker worker)
        {
            try
            {
                await _context.Workers.AddAsync(worker);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Worker worker, int id)
        {
            try
            {
                var workerToBeUpdated = await _context.Workers.Where(w => w.IsActive && w.Id == id).FirstAsync();
                if(workerToBeUpdated == null)
                {
                    return false;
                }
                workerToBeUpdated = worker;
                _context.Workers.Update(workerToBeUpdated);
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
                var workerToBeDeleted = await _context.Workers.Where(w => w.IsActive && w.Id == id).FirstOrDefaultAsync();
                if (workerToBeDeleted != null)
                {
                    workerToBeDeleted.IsActive = false;
                    _context.Workers.Update(workerToBeDeleted);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
