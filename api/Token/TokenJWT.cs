using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.IdentityModel.Tokens;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public static class TokenJWT{
    public static string gerarToken(Usuarios user){
        var geradorToken = new JwtSecurityTokenHandler();
        var chave = Encoding.ASCII.GetBytes(settings.secret);

        var conteudoToken = new SecurityTokenDescriptor{
            Subject = new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.NameIdentifier, user.id.ToString())
            }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(chave),SecurityAlgorithms.HmacSha256),
        };
        var token = geradorToken.CreateToken(conteudoToken);
        return geradorToken.WriteToken(token);
    }
}