using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace GlobalDev.Tools.Extensions
{
    public static class JWTExtensions
    {
        public static string GetInfo(this IEnumerable<Claim> claims, string info)
        {
            return claims.FirstOrDefault(x => x.Type == info)?.Value;
        }
    }
}
