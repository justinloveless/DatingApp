using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            // gets the username from the token that we're using
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}