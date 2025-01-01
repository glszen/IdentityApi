﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IdentityApi
{
    public static class Helper
    {
        public static string GenerateJwtToken(string email, string key, string issuer, string audience)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var credentails = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, email)
            };

            var token = new JwtSecurityToken(issuer:issuer, audience: audience, claims: claims, expires:DateTime.Now.AddMinutes(30),
                signingCredentials:credentails);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}