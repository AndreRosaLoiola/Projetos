using Mapeamento.Data;
using Mapeamento.Models;
using Microsoft.AspNetCore.Mvc;
using ProejtoApiAndre.Repositorio;
using ProjetoApiAndre.ProjetoWeb;

namespace ProjetoApiAndre.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private readonly IRepositorio _Ireposite;

        public PessoaController(IRepositorio repositorio)

        {
            _Ireposite = repositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> BuscartodasPessoas()
        {
            List<Pessoa> pessoas = _Ireposite.BuscarTodasPessoas();
            return Ok(pessoas);

        }
        [HttpPost]
        public async Task<ActionResult<PessoaViewModel>> Cadastrar([FromBody]PessoaViewModel _pessoa)
        {
            Pessoa p = new Pessoa();
            p.Nome=_pessoa.Nome;
            p.SobreNome = _pessoa.Sobrenome;
            p.Sexo = _pessoa.Sexo;
            p.DataNascimento = _pessoa.DataNascimento;

            Pessoa pessoas =_Ireposite.AddPessoa(p);

            return Ok(p);
        }
    
    }
}

