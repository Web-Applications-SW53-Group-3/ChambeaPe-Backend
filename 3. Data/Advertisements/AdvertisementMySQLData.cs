using _3._Data.Model;
using _3._Data.Context;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Advertisements
{
    public class AdvertisementMySQLData : IAdvertisementData
    {
        private ChambeaPeContext _context;

        public AdvertisementMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Advertisement>> GetAllAsync()
        {
            return await _context.Advertisements.Where(a => a.IsActive).ToListAsync();
        }

        public async Task<Advertisement> GetByIdAsync(int id)
        {
            return await _context.Advertisements.Where(a => a.IsActive).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> CreateAsync(Advertisement advertisement)
        {
            try
            {
                await _context.Advertisements.AddAsync(advertisement);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Advertisement advertisement, int id)
        {
            try
            {
                var advertisementToBeUpdated = await _context.Advertisements.FirstOrDefaultAsync(a => a.Id == id);
                if (advertisementToBeUpdated != null)
                {
                    advertisementToBeUpdated.Category = advertisement.Category;
                    advertisementToBeUpdated.Text = advertisement.Text;
                    advertisementToBeUpdated.StartDay = advertisement.StartDay;
                    advertisementToBeUpdated.EndDay = advertisement.EndDay;
                    advertisementToBeUpdated.PictureUrl = advertisement.PictureUrl;
                    advertisementToBeUpdated.DateUpdated = DateTime.Now;
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
                var advertisementToBeDeleted = await _context.Advertisements.Where(w => w.IsActive && w.Id == id).FirstOrDefaultAsync();;
                if (advertisementToBeDeleted != null)
                {
                    advertisementToBeDeleted.IsActive = false;
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
