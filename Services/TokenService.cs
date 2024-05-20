
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuarioAPI8.Models;

namespace UsuarioAPI8.Services
{
    public class TokenService
    {

        private IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id),
                new Claim("documento", usuario.Documento),
            };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SKJFHAK32323892839ASDHIOHKJS397EDWKHFJ"));
            //var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SymmetricSecurityKey"]));

            var signInCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddMinutes(5),
                claims: claims,
                signingCredentials: signInCredentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}