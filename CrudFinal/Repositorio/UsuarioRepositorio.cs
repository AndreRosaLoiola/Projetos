using CrudFinal.ModelsApi;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace CrudFinal.Repositorio
{
    public class UsuarioRepositorio : IUsuario
    {
        private readonly string url = "https://localhost:7021/Pessoa";
        public List<PessoaApiModel> BuscartodasPessoas()
        {
            var cliente = new HttpClient();

            var resposta = cliente.GetStringAsync(url);
            resposta.Wait();


            resposta.Result.ToList();
            var retorno = JsonConvert.DeserializeObject<PessoaApiModel[]>(resposta.Result).ToList();



            return retorno;
        }

        public PessoaApiModel Cadastrar(PessoaApiModel pessoa)
        {
            var PessoaCriada = new PessoaApiModel();
            var cliente = new HttpClient();
            string jsonObjeto = JsonConvert.SerializeObject(pessoa);
            var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");

            var resposta = cliente.PostAsync(url, content);
            resposta.Wait();
            if (resposta.Result.IsSuccessStatusCode)
            {
                var retorno = resposta.Result.Content.ReadAsStringAsync();
                PessoaCriada = JsonConvert.DeserializeObject<PessoaApiModel>(retorno.Result);

                
            }
            return PessoaCriada;  
            }
    }
}
