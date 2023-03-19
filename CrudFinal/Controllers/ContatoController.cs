using CrudFinal.Models;
using CrudFinal.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CrudFinal.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _ContatoRepositorio;
        public ContatoController(IContatoRepositorio ContatoRepositorio)
        {

            _ContatoRepositorio = ContatoRepositorio;
        }
        public IActionResult Index()
        {
            var contato = _ContatoRepositorio.BuscarTodos();
            return View(contato);
        }


        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _ContatoRepositorio.Listarporid(id);
            return View(contato);
        }

        public IActionResult ConfirmarExclusao(int id)
        {
            ContatoModel contato = _ContatoRepositorio.Listarporid(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _ContatoRepositorio.Apagar(id);
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_ContatoRepositorio.BuscarEmail(contato)) {
                        TempData["UsuarioExisteEmail"] = "E-MAIL JÁ CADASTRADO";
                        return View(contato);
                        
                           
                    }

                     if (_ContatoRepositorio.BuscarCpf(contato))
                    {
                        TempData["UsuarioExisteCpf"] = "CPF JÁ CADASTRADO";
                        return View(contato);
                    }

                    _ContatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);
            }

            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops,não conseguimos cadastrar seu contato ,tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _ContatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
