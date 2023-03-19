using CrudFinal.ModelsApi;
using CrudFinal.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;

namespace CrudFinal.Controllers
{


    public class ApiPessoaController : Controller
    {
        string _apiPessoa = "https://localhost:7021/Pessoa";

        private readonly IUsuario _IUsuario;
        public ApiPessoaController(IUsuario IUsuario)
        {
            _IUsuario = IUsuario;
        }
        
        public IActionResult Index()
        {
            return View(_IUsuario.BuscartodasPessoas());   
        }

        public IActionResult Criar(PessoaApiModel collection)
        {
            _IUsuario.Cadastrar(collection);
            

            



            return View(collection); 
        }

    }
}
