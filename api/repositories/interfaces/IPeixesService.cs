public interface IPeixesService
{
    Task<List<Peixes>> ListarPeixes();
    Task<Peixes> AdicionarPeixe(Peixes peixe);
    Task<Peixes> ListarUnicoPeixe(int id);
  
}