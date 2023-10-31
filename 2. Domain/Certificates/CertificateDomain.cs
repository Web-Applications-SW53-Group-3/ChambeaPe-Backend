using _2._Domain.Exceptions;
using _3._Data.Model;
using _3._Data.Certificates;
using _2._Domain.Workers;
using _3._Data.Workers;


namespace _2._Domain.Certificates
{
    public class CertificateDomain : ICertificateDomain
    {
        private readonly ICertificateData _certificateData;
        private readonly IWorkerDomain _workerDomain;
        private readonly IWorkerData _workerData;

        public CertificateDomain(ICertificateData certificateData, IWorkerDomain workerDomain, IWorkerData workerData)
        {
            _certificateData = certificateData;
            _workerDomain = workerDomain;
            _workerData = workerData;
        }

        public async Task<bool> CreateAsync(Certificate certificate, int workerId)
        {
            var existsWorker = await _workerDomain.ExistsByWorkerId(workerId);

            if (!existsWorker) return false;
            
            var worker = await _workerData.GetByIdAsync(workerId);
            certificate.WorkerId = worker.Id;
            return await _certificateData.CreateAsync(certificate);
        }

        public async Task<bool> UpdateAsync(Certificate certificate, int id)
        {
            Certificate certificateToBeUpdated = await _certificateData.GetByIdAsync(id);

            if (certificateToBeUpdated == null)
            {
                throw new InvalidCertificateIDException();
            }

            return await _certificateData.UpdateAsync(certificate, id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Certificate certificateToBeDeleted = await _certificateData.GetByIdAsync(id);
            if (certificateToBeDeleted != null)
            {
                return await _certificateData.DeleteAsync(id);
            }

            throw new InvalidCertificateIDException();
        }
    }
}