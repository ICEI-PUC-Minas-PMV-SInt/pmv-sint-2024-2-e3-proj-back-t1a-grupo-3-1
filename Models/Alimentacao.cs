using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_1._0_eixo3_2024.Models
{
    public class Alimentacao
    {
        [Key]
        public int IdAlimentacao { get; set; }

        [Display(Name = "Hora")]
        public DateTime HoraAlimentacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Obrigatório Informar o Tipo de Alimentação!")]
        [Display(Name = "Tipo de Alimentação")]
        public TipoAlimentacao Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Quantidade de Alimento administrada!")]
        [Display(Name = "Quantidade")]
        public int QuantidadeAlimentacao { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Unidade de Medida!")]
        [Display(Name = "Unidade de Medida")]
        public UnidadeMedida UnidadeMedida { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Cachorro!")]
        [Display(Name = "Cachorro")]
        public int IdCachorro { get; set; }

        [ForeignKey("IdCachorro")]
        public Cachorro Cachorro { get; set; }

    }

    public enum TipoAlimentacao
    {
        Ração_Seca,
        Ração_Úmida,
        Alimento_Caseiro,
        Petisco,
        Alimento_Cru
    }

    public enum UnidadeMedida
    {
        Copo,
        gramas,
        Scoop,
        Vasilhame
    }
}
