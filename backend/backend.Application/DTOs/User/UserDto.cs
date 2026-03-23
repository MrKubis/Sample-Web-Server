namespace backend.Application.DTOs.User;

public record LoginDto(string Email, string Password);

public record LoginResultDto();

public record RegisterDto(string NickName,string Email, string Password);