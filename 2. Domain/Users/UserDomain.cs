using System.Threading.Tasks;
using _2._Domain.Exceptions;
using _3._Data.Model;
using _3._Data.Users;
using AutoMapper;

namespace _2._Domain.Users
{
    public class UserDomain : IUserDomain
    {
        private IUserData _userData;
        private IMapper _mapper;

        public UserDomain(IUserData userData, IMapper mapper)
        {
            _userData = userData;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(User user, string userRole)
        {
            User existingEmailUser = await _userData.GetByEmailAsync(user.Email);
            User existingPhoneNumberUser = await _userData.GetByPhoneNumberAsync(user.PhoneNumber);

            if (existingEmailUser != null)
            {
                throw new EmailAlreadyExistsException();
            }

            if (existingPhoneNumberUser != null)
            {
                throw new PhoneNumberAlreadyExistsException();
            }
            user.UserRole = userRole;
            return await _userData.CreateAsync(user);
        }

        public async Task<bool> UpdateAsync(User user, int id, string userRole)
        {
            User existingEmailUser = await _userData.GetByEmailAsync(user.Email);
            User existingPhoneNumberUser = await _userData.GetByPhoneNumberAsync(user.PhoneNumber);

            if (existingEmailUser != null && existingEmailUser.Id!=id)
            {
                throw new EmailAlreadyExistsException();
            }

            if (existingPhoneNumberUser != null && existingPhoneNumberUser.PhoneNumber != user.PhoneNumber)
            {
                throw new PhoneNumberAlreadyExistsException();
            }

            var userToBeUpdated = await _userData.GetByIdAsync(id);

            if (userToBeUpdated != null)
            {
                //_mapper.Map(user, userToBeUpdated);
                userToBeUpdated.UserRole = userRole;
                userToBeUpdated.FirstName = user.FirstName;
                userToBeUpdated.LastName = user.LastName;
                userToBeUpdated.Email = user.Email;
                userToBeUpdated.PhoneNumber = user.PhoneNumber;
                userToBeUpdated.Description = user.Description;
                userToBeUpdated.Birthdate = user.Birthdate;
                userToBeUpdated.Gender = user.Gender;
                userToBeUpdated.ProfilePic = user.ProfilePic;

                return await _userData.UpdateAsync(userToBeUpdated, id);
            }

            return false;
     
        }

        public async Task<bool> DeleteAsync(int id)
        {
            User userToBeDeleted = await _userData.GetByIdAsync(id);
            if (userToBeDeleted != null)
            {
                return await _userData.DeleteAsync(id);
            }
            
            throw new InvalidUserIDException("User");
        }
    }
}
