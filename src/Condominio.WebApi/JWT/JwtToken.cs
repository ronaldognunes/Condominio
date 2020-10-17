using Condominio.Domain.Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Condominio.WebApi.JWT
{
    public static class JwtToken
    {
        public static string GerarToken(Usuarios usuario) {
            var Tokenhandler = new JwtSecurityTokenHandler();
            // colocar para pegar do appsetings
            var key = Encoding.ASCII.GetBytes("@$WWEOISD(*)*&#¨&¨@#&@");
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Email, usuario.Login.Email.EdEmail),
                    new Claim(ClaimTypes.Role, usuario.Login.Perfil)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var Token = Tokenhandler.CreateToken(TokenDescriptor);
            return Tokenhandler.WriteToken(Token);
        }
    }
}
