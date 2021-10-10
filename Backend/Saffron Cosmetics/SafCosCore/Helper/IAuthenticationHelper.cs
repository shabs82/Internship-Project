using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Helper
{
    public interface IAuthenticationHelper
    {
        
       
            void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
            bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt);
            string GenerateToken(User user);
            ClaimsPrincipal getExpiredClaims(string token);
        
    }
}
