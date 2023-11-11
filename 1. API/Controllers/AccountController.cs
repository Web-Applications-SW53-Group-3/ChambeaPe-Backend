using _1._API.Request;
using _3._Data.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class AccountController : Controller
{
    private readonly IUserData _userData;
    public AccountController(IUserData userData)
    {
        _userData = userData;
    }

    [HttpPost]
    [Route("/account/login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        var user = await _userData.GetByEmailAsync(loginRequest.Email);
        if (user == null)
        {
            return BadRequest($"Email {loginRequest.Email} does not exist");
        }

        if(user.Password != loginRequest.Password)
        {
            return BadRequest($"Incorrect password");
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Email, loginRequest.Email),
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            new Claim(ClaimTypes.Role, user.UserRole)
        };

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        return Ok(new { success = true, message = "Login successful" });
    }

    [HttpGet]
    [Route("/account/logout")]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return Ok(new { success = true, message = "Logout successful" });
    }
}
