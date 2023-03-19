using CrudFinal.Models;

namespace CrudFinal.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Listarporid(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar (ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
        
        bool BuscarEmail(ContatoModel contato);

        bool BuscarCpf(ContatoModel contato);
    }
}
