public interface ITokenService
{
    public Task<List<Token>> Listar_token();
    public Task<Token>ListarUnicoToken(int id);
    public Task<Token> deletartoken(int id);
    public Task<Token> atualizarToken(int id, Token token);
    public Task<Token> adicionarToken(Token token);
}