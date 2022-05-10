using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hora_do_Banho_Teste
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }
        [Key()]
        public char CPF { get; set; }
        public DateOnly Data_Nascimento { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o telefone!")]
        public int Telefone { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o e-mail!")]
        public char Email { get; set; }
        public char Endereco { get; set; }
        [Required(ErrorMessage ="Informe sua senha!")]
        public char Senha { get; set; }

    }
}
