using _3._Data.Model;
using _3._Data.Context;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Certificates
{
    public class CertificateMySQLData : ICertificateData
    {
        private ChambeaPeContext _context;

        public CertificateMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Certificate>> GetAllAsync()
        {
            return await _context.Certificates.Where(c => c.IsActive).ToListAsync();
        }

        public async Task<Certificate?> GetByIdAsync(int id)
        {
            return await _context.Certificates.Where(c => c.IsActive).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Certificate?> GetByCertificateIdAsync(string certificateId)
        {
            return await _context.Certificates.Where(c => c.IsActive && c.CertificateId == certificateId).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateAsync(Certificate certificate)
        {
            try
            {
                await _context.Certificates.AddAsync(certificate);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Certificate certificate, int id)
        {
            try
            {
                var certificateToBeUpdated = await _context.Certificates.FirstOrDefaultAsync(c => c.Id == id);
                if (certificateToBeUpdated != null)
                {
                    certificateToBeUpdated.CertificateId = certificate.CertificateId;
                    certificateToBeUpdated.Name = certificate.Name;
                    certificateToBeUpdated.ImgUrl = certificate.ImgUrl;
                    certificateToBeUpdated.InstitutionName = certificate.InstitutionName;
                    certificateToBeUpdated.TeacherName = certificate.TeacherName;
                    certificateToBeUpdated.IssueDate = certificate.IssueDate;
                    certificateToBeUpdated.CertificateName = certificate.CertificateName;
                    certificateToBeUpdated.DateUpdated = DateTime.Now;
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
                var certificateToBeDeleted = await _context.Certificates.FirstOrDefaultAsync(c => c.Id == id);
                if (certificateToBeDeleted != null)
                {
                    certificateToBeDeleted.IsActive = false;
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
