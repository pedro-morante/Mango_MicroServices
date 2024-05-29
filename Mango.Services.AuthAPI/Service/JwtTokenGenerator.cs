using Mango.Services.AuthAPI.Models;
using Mango.Services.AuthAPI.Service.IService;

namespace Mango.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}
