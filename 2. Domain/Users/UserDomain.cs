﻿using _2._Domain.Exceptions;
using _3._Data.Model;
using _3._Data.Users;

namespace _2._Domain.Users
{
    public class UserDomain : IUserDomain
    {
        private IUserData _userData;

        public UserDomain(IUserData userData)
        {
            _userData = userData;
        }

        public async Task<bool> CreateAsync(User user)
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

            return await _userData.CreateAsync(user);
        }

        public async Task<bool> UpdateAsync(User user, int id)
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

            return await _userData.UpdateAsync(user, id);
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
