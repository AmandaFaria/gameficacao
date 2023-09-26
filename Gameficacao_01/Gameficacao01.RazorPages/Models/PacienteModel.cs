using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gameficacao01.RazorPages.Models
{
    public class PacienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? PacienteId {get;set;}
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string? NomePaciente {get;set;}
        [Required(ErrorMessage ="Sobrenome é obrigatório")]
        public string? SobrenomePaciente {get;set;}
        [Required(ErrorMessage ="Número de identicacão é obrigatório")]
        public string? NumIdentificacao {get;set;}
        public string HistoricoMedico {get;set;}
        public List<ConsultaModel> Consultas {get;set;}
    }
}