using _3._Data.Model;
using _3._Data.Workers;
using _2._Domain.Users;
using _3._Data.Users;
using _2._Domain.Exceptions;

namespace _2._Domain.Workers
{
    public class WorkerDomain : IWorkerDomain
    {
        private readonly IWorkerData _workerData;
        private readonly IUserDomain _userDomain;
        private readonly IUserData _userData;

        public WorkerDomain(IWorkerData workerData, IUserDomain userDomain, IUserData userData)
        {
            _workerData = workerData;
            _userDomain = userDomain;
            _userData = userData;
        }
        public async Task<bool> CreateAsync(Worker worker, User user)
        {
            await _userDomain.CreateAsync(user);
            User newUser = await _userData.GetByEmailAsync(user.Email);
            worker.UserId=newUser.Id;
            return await _workerData.CreateAsync(worker);
        }

        public async Task<bool> UpdateAsync(Worker worker, User user, int id)
        {
            Worker workerToBeUpdated = await _workerData.GetByIdAsync(id);
            User userToBeUpdated = await _userData.GetByIdAsync(worker.UserId);

            if (workerToBeUpdated==null)
            {
                throw new InvalidUserIDException("Worker");
            }

            bool workerUpdated = await _workerData.UpdateAsync(worker, id);
            bool userUpdated = await _userDomain.UpdateAsync(user, worker.UserId);

            return workerUpdated && userUpdated;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Worker workerToBeDeleted = await _workerData.GetByIdAsync(id);
            if (workerToBeDeleted != null)
            {
                return await _workerData.DeleteAsync(id);
            }

            throw new InvalidUserIDException("Worker");
        }
    }
}
