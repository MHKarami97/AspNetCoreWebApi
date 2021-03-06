﻿using System.Threading.Tasks;
using Entities.User;

namespace Services.Services
{
    public interface IJwtService
    {
        Task<AccessToken> GenerateAsync(User user);

        Task DeleteExpiredTokensAsync();

        Task InvalidateUserTokensAsync(int userId);

        Task DeleteTokensWithSameRefreshTokenSourceAsync(string refreshTokenIdHashSource);

        Task AddUserTokenAsync(UserTokenHandler userToken);

        Task<UserTokenHandler> FindTokenAsync(string refreshTokenValue);

        string GetRefreshTokenSerial(string refreshTokenValue);
    }
}