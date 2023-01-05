using Microsoft.EntityFrameworkCore;

public class TokenService : ITokenService
{
    private readonly AppDbContext _context;

    public TokenService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Token> adicionarToken(Token token)
    {
        await _context.Tokens.AddAsync(token);
        await _context.SaveChangesAsync();
        return token;

    }

    public async Task<Token> atualizarToken(int id, Token token)
    {
        Token tokenn = await _context.Tokens.FindAsync(id);
        if(token == null){
            throw new Exception("usuario não encontrado");
        }
        tokenn.Email = token.Email;
        tokenn.Jwt = token.Jwt;
        _context.Tokens.Update(tokenn);
        await _context.SaveChangesAsync();
        return tokenn;
    }

    public async Task<Token> deletartoken(int id)
    {
        Token token = await _context.Tokens.FindAsync(id);
        if(token == null){
            throw new Exception("token não encontrado");
        }
          await _context.SaveChangesAsync();
            return null;

    }

    public async Task<Token> ListarUnicoToken(int id)
    {
        Token token = await _context.Tokens.FindAsync(id);
        if(token == null){
            throw new Exception("token não encontrado");
        }
        return token;
    }

    public async Task<List<Token>> Listar_token()
    {
        return await _context.Tokens.ToListAsync();
    }
}