using Microsoft.EntityFrameworkCore;
public class PeixesService : IPeixesService
{
    private readonly AppDbContext context;

    public PeixesService(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<Peixes> AdicionarPeixe(Peixes peixe)
    {
        await context.peixes.AddAsync(peixe);
        await context.SaveChangesAsync();
    
        return peixe;
    }

    public async Task<Peixes> atualizarPeixe(int id, Peixes peixe)
    {
        Peixes peixee = await context.peixes.FindAsync(id);
        if(peixee == null){
            throw new Exception("erro ao tentar encontrar usuario");
        }
        peixee.Descricao = peixe.Descricao;
        peixee.imagem = peixe.imagem;
        peixee.NomePeixe = peixe.NomePeixe;
        context.peixes.Update(peixee);
        await context.SaveChangesAsync();
        return peixee;
    }

    public async Task<Peixes> DeletarPeixe(int id)
    {
        Peixes peixee = await context.peixes.FindAsync(id);
        if(peixee == null){
            throw new Exception("erro ao deletar peixe");
        }
        context.peixes.Remove(peixee);
        await context.SaveChangesAsync();
        return peixee;
    }

    public async Task<List<Peixes>> ListarPeixes()
    {
        return await context.peixes.ToListAsync();
    }

    public async Task<Peixes> ListarUnicoPeixe(int id)
    {
        Peixes peixe = await context.peixes.FindAsync(id);
        if(peixe == null){
            throw new Exception($"peixe não encontrado para o id: {id}");
        }
        return peixe;
    }
}