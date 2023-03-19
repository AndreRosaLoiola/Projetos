using CrudFinal.Data;
using CrudFinal.Models;

namespace CrudFinal.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
         _bancoContext=bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contato.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatodobanco = Listarporid(id);
            if (contatodobanco == null) throw new Exception("houve um erro");
            _bancoContext.Contato.Remove(contatodobanco);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatodobanco = Listarporid(contato.Id);
            if (contatodobanco == null) throw new Exception("houve um erro");
            contatodobanco.Nome= contato.Nome;
            contatodobanco.Email= contato.Email;
            contatodobanco.Cpf= contato.Cpf;
            contatodobanco.Rg = contato.Rg;
            contatodobanco.Celular= contato.Celular;
            contatodobanco.Cep = contato.Cep;
            contatodobanco.Cidade= contato.Cidade;
            contatodobanco.Data= contato.Data;
            contatodobanco.Sexo=contato.Sexo;
            _bancoContext.Contato.Update(contatodobanco);
            _bancoContext.SaveChanges();
            return contatodobanco;
        }

        public bool BuscarCpf(ContatoModel contato)
        {
            return _bancoContext.Contato.Any(b => b.Cpf == contato.Cpf);
        }

        public bool BuscarEmail(ContatoModel contato)
        {
          
           return _bancoContext.Contato.Any(b => b.Email==contato.Email);
            
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contato.ToList();
        }

        public ContatoModel Listarporid(int id)
        {
            return _bancoContext.Contato.FirstOrDefault(x=>x.Id==id);
        }
    }
}
