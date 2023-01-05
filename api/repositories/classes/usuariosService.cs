using Microsoft.EntityFrameworkCore;

public class usuariosService : IUsuariosService
{
    private readonly AppDbContext _context;

    public usuariosService(AppDbContext context)
    {
        _context = context;
        
    }

    public async Task<Usuarios> AdicionarUser(Usuarios user)
    {
        await _context.clientes.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<Usuarios> atualizarUser(int id, Usuarios user)
    {
        Usuarios userr = await _context.clientes.FindAsync(id);
        if(userr == null){
            throw new Exception("usuario não encontrado");
        }
        userr.Email = user.Email;
        userr.Nome = user.Nome;
        userr.Senha = user.Senha;
        _context.clientes.Update(userr);

        await _context.SaveChangesAsync();
        return userr;
    }

    public async Task<Usuarios> deletarUser(int id)
    {
        Usuarios user = await _context.clientes.FindAsync(id);
        if(user == null){
            throw new Exception("usuario não encontrado");
        }
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<Usuarios> listarunicoUser(int id)
    {
        Usuarios user = await _context.clientes.FindAsync(id);
        if(user== null){
            throw new Exception("usuario não encontrado");
        }
        return user;
    }

    public async Task<List<Usuarios>> listarUsers()
    {
        return await _context.clientes.ToListAsync();
    }
    public async Task <Usuarios> verificarEmail(Usuarios user){
        var registro = _context.clientes.Where(u => u.Email == user.Email).FirstOrDefault();
        if(registro != null){
            throw new Exception("Email ja cadastrado");
        }
        return null;
     }

}