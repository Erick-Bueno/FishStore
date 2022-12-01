public interface IPeixesService
{
    Task<List<Peixes>> ListarPeixes();
    Task<Peixes> AdicionarPeixe(Peixes peixe);
    Task<Peixes> ListarUnicoPeixe(int id);

    Task<Peixes> atualizarPeixe(int id, Peixes peixe);
    Task<Peixes> DeletarPeixe(int id);
  
}