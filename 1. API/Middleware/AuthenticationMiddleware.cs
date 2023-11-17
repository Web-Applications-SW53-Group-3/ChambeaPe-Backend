using _2._Domain.Token;

namespace _1._API.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ITokenDomain tokenDomain)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token != null)
            {
                await AttachUserToContext(context, token, tokenDomain);
            }

            await _next(context);
        }

        private async Task AttachUserToContext(HttpContext context, string token, ITokenDomain tokenDomain)
        {

            var principal = tokenDomain.ValidateJwtToken(token);
            if (principal != null)
            {
                context.User = principal;
            }
        }
    }
}
