using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _1._API.Filter
{
    public class AuthorizeFilterAttribute : Attribute, IAuthorizationFilter
    {
        private readonly List<string> _roles;

        public AuthorizeFilterAttribute(params string[] roles)
        {
            _roles = (roles.Count() > 0) ? roles.FirstOrDefault().Split(",").ToList() : new List<string>();
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;


            var user = context.HttpContext.User;

            if (user == null || (!_roles.Any() && !user.Identity.IsAuthenticated) || (_roles.Any() && !_roles.Any(user.IsInRole)))
            {
                context.Result = new JsonResult(new { message = "Error 401 - Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
