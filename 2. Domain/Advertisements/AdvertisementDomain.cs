using _3._Data.Model;
using _3._Data.Advertisements;
using _3._Data.Workers;
using _2._Domain.Workers;
using _2._Domain.Exceptions;

namespace _2._Domain.Advertisements
{
    public class AdvertisementDomain : IAdvertisementDomain
    {
        private readonly IAdvertisementData _advertisementData;
        private readonly IWorkerDomain _workerDomain;
        private readonly IWorkerData _workerData;

        public AdvertisementDomain(IAdvertisementData advertisementData, IWorkerDomain workerDomain, IWorkerData workerData)
        {
            _advertisementData = advertisementData;
            _workerDomain = workerDomain;
            _workerData = workerData;
        }

        public async Task<bool> CreateAsync(Advertisement advertisement, int workerId)
        {
            var existsWorker = await _workerDomain.ExistsByWorkerId(workerId);

            if (!existsWorker)
            {
                return false;
            }

            var worker = await _workerData.GetByIdAsync(workerId);
            advertisement.WorkerId = worker.Id;
            return await _advertisementData.CreateAsync(advertisement);
        }

        public async Task<bool> UpdateAsync(Advertisement advertisement, int id)
        {
            Advertisement advertisementToBeUpdated = await _advertisementData.GetByIdAsync(id);

            if (advertisementToBeUpdated == null)
            {
                throw new InvalidAdvertisementIDException();
            }

            return await _advertisementData.UpdateAsync(advertisement, id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Advertisement advertisementToBeDeleted = await _advertisementData.GetByIdAsync(id);
            if (advertisementToBeDeleted != null)
            {
                return await _advertisementData.DeleteAsync(id);
            }

            throw new InvalidAdvertisementIDException();
        }
    }
}