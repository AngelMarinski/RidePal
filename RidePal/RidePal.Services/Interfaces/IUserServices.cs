﻿using RidePal.Data.Models;
using RidePal.Services.DTOModels;
using RidePal.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RidePal.Services.Interfaces
{
    public interface IUserServices
    {
        public Task<IEnumerable<UserDTO>> GetAsync();

        public Task<UserDTO> PostAsync(UpdateUserDTO obj);

        public Task<UserDTO> UpdateAsync(int id, UpdateUserDTO obj);

        public Task<UserDTO> DeleteAsync(string email);

        public Task<int> UserCount();

        public Task<bool> IsExistingAsync(string email);

        public Task<bool> IsExistingUsernameAsync(string username);

        public Task<UserDTO> GetUserDTOAsync(string username);

        public Task<UserDTO> GetUserDTOByEmailAsync(string email);

        public Task<UserDTO> GetUserDTOAsync(int id);

        public Task SendFriendRequestAsync(string senderEmail, string recipientEmail);

        public Task AcceptFriendRequestAsync(string senderEmail, string recipientEmail);

        public Task DeclineFriendRequestAsync(string senderEmail, string recipientEmail);

        public Task RemoveFriendAsync(string email, string friendEmail);

        public Task BlockUserAsync(int id);

        public Task UnblockUserAsync(int id);

        public Task<IEnumerable<UserDTO>> SearchAsync(string userSearch, int type);

        public Task<IEnumerable<UserDTO>> GetAllFriendsAsync(string email);

        public Task<IEnumerable<FriendRequest>> GetAllFriendRequestsAsync(string email);

        public Task<IEnumerable<PlaylistDTO>> GetAllPlaylistsAsync(string email);

        public Task GenerateForgotPasswordTokenAsync(User user);

        public Task<bool> ResetPasswordAsyncAsync(ResetPasswordModel model);

        public Task GenerateEmailConfirmationTokenAsync(User user);

        public Task<bool> ConfirmEmailAsync(string uid, string token);
    }
}