using _1._API.Request;
using _2._Domain.Users;
using _3._Data.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class AccountController : Controller
{
    private readonly IUserData _userData;
    private readonly IUserDomain _userDomain;
    public AccountController(IUserData userData, IUserDomain userDomain)
    {
        _userData = userData;
        _userDomain = userDomain;
    }

    [HttpPost]
    [Route("/account/login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        var user = await _userData.GetByEmailAsync(loginRequest.Email);
        if (user == null)
        {
            return BadRequest(new { error = "EmailNotFound", message = $"Email {loginRequest.Email} does not exist" });
        }
        string hashedPassword = user.Password;
        if(!_userDomain.VerifyPassword(loginRequest.Password, hashedPassword))
        {
            return BadRequest(new { error = "IncorrectPassword", message = "Incorrect password" });
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Email, loginRequest.Email),
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            new Claim(ClaimTypes.Role, user.UserRole),
            new Claim("UserId", user.Id.ToString())
        };

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        return Ok(new { success = true, message = "Login successful", claims });
    }

    [HttpGet]
    [Route("/account/logout")]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return Ok(new { success = true, message = "Logout successful" });
    }
}
