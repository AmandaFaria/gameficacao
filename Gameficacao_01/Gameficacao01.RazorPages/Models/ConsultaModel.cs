using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gameficacao01.RazorPages.Models
{
    public class ConsultaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConsultaId { get; set; }

        [Required(ErrorMessage ="Nome do médico é obrigatório")]
        public string? NomeMedicoConsulta { get; set; }

        [Required(ErrorMessage ="Nome do paciente é obrigatório")]
        public string NomePacienteConsulta { get; set; }

        
        [DataType(DataType.DateTime)]
        public DateTime DataHoraConsulta { get; set; }

        [Required(ErrorMessage ="Tipo de consulta é obrigatório")]
        public string? TipoConsulta { get; set; } // Pode ser "Presencial" ou "Online"

        public string ObservacoesConsulta { get; set; }
    }
}