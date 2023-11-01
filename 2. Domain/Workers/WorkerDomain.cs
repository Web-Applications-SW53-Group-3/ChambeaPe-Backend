using System.Threading.Tasks;
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
        
        public async Task<bool> ExistsByWorkerId(int id)
        {
            Worker? workerToBeFound = await _workerData.ExistsByIdAsync(id);

            if (workerToBeFound == null)
            {
                throw new InvalidWorkerIDException(id.ToString());
            }

            return true;
        }
        public async Task<bool> CreateAsync(Worker worker, User user)
        {
            await _userDomain.CreateAsync(user, "W");
            User newUser = await _userData.GetByEmailAsync(user.Email);
            if(newUser == null)
            {
                throw new UserRegistrationException();
            }
            worker.UserId=newUser.Id;
            return await _workerData.CreateAsync(worker);
        }

        public async Task<bool> UpdateAsync(Worker worker, User user, int id)
        {
            Worker workerToBeUpdated = await _workerData.GetByIdAsync(id);
            bool userUpdated = await _userDomain.UpdateAsync(user, workerToBeUpdated.UserId, "W");
            User updatedUser = await _userData.GetByIdAsync(workerToBeUpdated.UserId);

            if (workerToBeUpdated==null)
            {
                throw new InvalidUserIDException("Worker");
            }

            //_mapper.Map(worker, workerToBeUpdated);
            workerToBeUpdated.Occupation = worker.Occupation;

            bool workerUpdated = await _workerData.UpdateAsync(workerToBeUpdated, id);
            

            return workerUpdated && userUpdated;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Worker workerToBeDeleted = await _workerData.GetByIdAsync(id);
            if (workerToBeDeleted == null)
            {
                throw new InvalidUserIDException("Worker");
            }

            bool userDeleted = await _userDomain.DeleteAsync(workerToBeDeleted.UserId);
            bool workerDeleted = await _workerData.DeleteAsync(id);
            return userDeleted && workerDeleted;
        }
    }
}
