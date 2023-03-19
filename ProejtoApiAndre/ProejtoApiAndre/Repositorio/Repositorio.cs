using Mapeamento.Data;
using Mapeamento.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ProejtoApiAndre.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly DB_ESTUDO _ESTUDO;
        public Repositorio(DB_ESTUDO ProjetoApi)
        {
            _ESTUDO = ProjetoApi;
        }

        public Pessoa AddPessoa(Pessoa pessoa)
        {
            _ESTUDO.TB_PESSOA.Add(pessoa);
            _ESTUDO.SaveChanges();
            return pessoa;
        }

        public bool apagar(int id)
        {
            Pessoa pessoaid = BuscarPorId(id);

            if (pessoaid == null)
            {
                throw new Exception($"USUARIO PARA O ID :{id} NÃO FOI ENCONTRADO");
            }

            _ESTUDO.TB_PESSOA.Remove(pessoaid);
            _ESTUDO.SaveChanges();
            return true;
        }

        public Pessoa AtualizarPessoa(Pessoa pessoa, int id)
        {
            Pessoa pessoaid = BuscarPorId(id);

            if (pessoaid == null)
            {
                throw new Exception($"USUARIO PARA O ID :{id} NÃO FOI ENCONTRADO");
            }

            pessoaid.Nome = pessoa.Nome;
            pessoaid.SobreNome = pessoa.SobreNome;
            pessoaid.Sexo = pessoa.Sexo;
            pessoaid.DataNascimento = pessoa.DataNascimento;
            _ESTUDO.TB_PESSOA.Update(pessoaid);
            _ESTUDO.SaveChanges();
            return pessoaid;

        }

        public Pessoa BuscarPorId(int id)
        {
            return _ESTUDO.TB_PESSOA.FirstOrDefault(x => x.Id == id);
        }

        public List<Pessoa> BuscarTodasPessoas()
        {
            return _ESTUDO.TB_PESSOA.ToList();
        }
    }
}
