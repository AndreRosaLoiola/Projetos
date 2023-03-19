using CrudFinal.ModelsApi;

namespace CrudFinal.Repositorio
{
    public interface IUsuario
    {
        List<PessoaApiModel> BuscartodasPessoas();
        PessoaApiModel Cadastrar(PessoaApiModel pessoa);

    }
}
