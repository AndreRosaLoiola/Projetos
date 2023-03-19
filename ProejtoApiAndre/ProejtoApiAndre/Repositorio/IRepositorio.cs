using Mapeamento.Models;

namespace ProejtoApiAndre.Repositorio
{
    public interface IRepositorio
    {

        List<Pessoa> BuscarTodasPessoas();

        Pessoa BuscarPorId(int id);

        Pessoa AddPessoa (Pessoa pessoa);

        Pessoa AtualizarPessoa(Pessoa pessoa, int id);

        bool apagar (int id);

    }
}
