using _3._Data.Context;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Postulations
{
    public class PostulationMySQLData : IPostulationData
    {
        private ChambeaPeContext _context;
        public PostulationMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }
        public async Task<Postulation?> GetByIdAsync(int postulationId)
        {
            return await _context.Postulations
                .Where(p => p.IsActive && p.Id == postulationId)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Postulation>> GetAllByPostIdAsync(int postId)
        {
            return await _context.Postulations
                .Where(p => p.IsActive && p.PostId == postId)
                .ToListAsync();
        }

        public async Task<List<Postulation>> GetAllByWorkerIdAsync(int workerId)
        {
            return await _context.Postulations
                .Where(p => p.IsActive && p.WorkerId == workerId)
                .ToListAsync();
        }

        public async Task<bool> CreateAsync(Postulation postulation)
        {
            postulation.DateCreated = DateTime.Now;
            postulation.IsActive = true;
            await _context.Postulations.AddAsync(postulation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int postulationId)
        {
            var postulationToBeDeleted = await _context.Postulations
                .Where(p => p.IsActive && p.Id == postulationId)
                .FirstOrDefaultAsync();

            if (postulationToBeDeleted != null)
            {
                postulationToBeDeleted.IsActive = false;
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> ExistsByWorkerIdAndPostIdAsync(int workerId, int postId)
        {
            return await _context.Postulations
                .Where(p => p.IsActive && p.WorkerId == workerId && p.PostId == postId)
                .AnyAsync();
        }
    }
}
