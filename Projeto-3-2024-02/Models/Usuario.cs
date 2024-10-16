using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_3_2024_02.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o código de área!")]
        public string CodigoArea { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número de telefone!")]
        public string NumeroTelefone {  get; set; }
    }
}
