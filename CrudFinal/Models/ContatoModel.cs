using System.ComponentModel.DataAnnotations;

namespace CrudFinal.Models
{
    public class ContatoModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite o RG")]
        public string Rg { get; set; }
        [Required(ErrorMessage ="Digite o cpf")]
        public string Cpf { get; set; }
        [Required(ErrorMessage ="Digite o E-mail")]
        [EmailAddress(ErrorMessage ="Digite um E-mail Valido")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Digite o celular do Contato")]
        [Phone(ErrorMessage ="Digite um telefone valido")]
        public string Celular { get; set; }
        [Required(ErrorMessage ="Digite o Cep")]
        public string Cep { get; set; }
        [Required(ErrorMessage ="Digite cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage ="Informe o Sexo")]
        public string Sexo { get; set; }
      
       
        
        public DateTime Data { get; set; }
        
        }
}
