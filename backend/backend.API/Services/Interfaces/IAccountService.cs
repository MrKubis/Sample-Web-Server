using backend.Application.DTOs.User;

namespace backend.Services.Interfaces;

public interface IAccountService
{
    public Task<LoginResultDto?> Login(LoginDto dto);
}