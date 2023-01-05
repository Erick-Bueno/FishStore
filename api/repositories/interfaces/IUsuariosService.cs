public interface IUsuariosService
{
    public Task<List<Usuarios>> listarUsers();
    public Task<Usuarios> AdicionarUser(Usuarios user);
    public Task<Usuarios> listarunicoUser(int id);
    public Task<Usuarios> deletarUser(int id);
    public Task<Usuarios> atualizarUser(int id, Usuarios user);

    public Task <Usuarios> verificarEmail(Usuarios user);
  

    
}