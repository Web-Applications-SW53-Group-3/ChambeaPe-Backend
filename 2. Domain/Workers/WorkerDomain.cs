using _3._Data.Model;
using _3._Data.Workers;
using _2._Domain.Users;
using _3._Data.Users;
using _2._Domain.Exceptions;
using AutoMapper;

namespace _2._Domain.Workers
{
    public class WorkerDomain : IWorkerDomain
    {
        private readonly IWorkerData _workerData;
        private readonly IUserDomain _userDomain;
        private readonly IUserData _userData;
        private readonly IMapper _mapper;

        public WorkerDomain(IWorkerData workerData, IUserDomain userDomain, IUserData userData, IMapper mapper)
        {
            _workerData = workerData;
            _userDomain = userDomain;
            _userData = userData;
            _mapper = mapper;
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
            bool userUpdated = await _userDomain.UpdateAsync(user, workerToBeUpdated.UserId);

            if (workerToBeUpdated==null)
            {
                throw new InvalidUserIDException("Worker");
            }

            worker.UserId = workerToBeUpdated.UserId;
            _mapper.Map(worker, workerToBeUpdated);

            bool workerUpdated = await _workerData.UpdateAsync(workerToBeUpdated, id);
            

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
