using System.Security.Claims;

namespace _2._Domain.Token
{
    public interface ITokenDomain
    {
        string GenerateJwtToken(Claim[] claims);
        ClaimsPrincipal ValidateJwtToken(string token);
    }
}
