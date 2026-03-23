using backend.Application.DTOs.User;
using backend.Services.Interfaces;

namespace backend.Services.Implementations;

public class AccountService : IAccountService
{
    public async Task<LoginResultDto?> Login(LoginDto dto)
    {
        await Task.Run(() => { });
       // some logging logic here
       return new LoginResultDto{};
    }
}