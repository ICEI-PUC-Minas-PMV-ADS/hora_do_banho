using System.ComponentModel.DataAnnotations;

namespace Hora_do_Banho_Teste.Models
{
    public class Cliente
    {
        [Table("Cliente")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome_Sobrenome { get; set; }
        [Key]
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
