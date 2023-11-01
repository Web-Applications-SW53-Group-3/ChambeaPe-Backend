using _3._Data.Model;
using _3._Data.Employers;
using _2._Domain.Users;
using _3._Data.Users;
using _2._Domain.Exceptions;

namespace _2._Domain.Employers
{
    public class EmployerDomain : IEmployerDomain
    {
        private readonly IEmployerData _employerData;
        private readonly IUserDomain _userDomain;
        private readonly IUserData _userData;
        public EmployerDomain(IEmployerData employerData, IUserDomain userDomain, IUserData userData)
        {
            _employerData = employerData;
            _userDomain = userDomain;
            _userData = userData;
        }

        public async Task<bool> CreateAsync(Employer employer, User user)
        {
            await _userDomain.CreateAsync(user, "E");
            User newUser = await _userData.GetByEmailAsync(user.Email);
            if (newUser == null)
            {
                throw new UserRegistrationException();
            }
            employer.UserId = newUser.Id;
            return await _employerData.CreateAsync(employer);
        }

        public async Task<bool> UpdateAsync(Employer employer, User user, int id)
        {
            Employer employerToBeUpdated = await _employerData.GetByIdAsync(id);
            bool userUpdated = await _userDomain.UpdateAsync(user, employerToBeUpdated.UserId, "E");
            User updatedUser = await _userData.GetByIdAsync(employerToBeUpdated.UserId);

            if (employerToBeUpdated == null)
            {
                throw new InvalidUserIDException("Employer");
            }

            bool employerUpdated = await _employerData.UpdateAsync(employerToBeUpdated, id);

            return employerUpdated && userUpdated;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Employer employerToBeDeleted = await _employerData.GetByIdAsync(id);
            if (employerToBeDeleted == null)
            {
                throw new InvalidUserIDException("Worker");
            }

            bool userDeleted = await _userDomain.DeleteAsync(employerToBeDeleted.UserId);
            bool employerDeleted = await _employerData.DeleteAsync(id);
            return userDeleted && employerDeleted;
        }
    }
}
