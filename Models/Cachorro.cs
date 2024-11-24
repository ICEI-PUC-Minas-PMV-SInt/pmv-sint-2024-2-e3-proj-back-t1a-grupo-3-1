using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_1._0_eixo3_2024.Models
{
    [Table("Cachorros")]
    public class Cachorro
    {
        [Key]
        public int IdCachorro { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome do cachorro!")]
        [Display(Name = "Nome")]
        public string NomeCachorro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento do cachorro!")]
        [Display(Name = "Nascimento")]
        public string NascimentoCachorro { get; set; }

        [Display(Name = "Raça")]
        public string RacaCachorro { get; set; }

        public ICollection<Alimentacao> Alimentacoes { get; set; }

    }
}
