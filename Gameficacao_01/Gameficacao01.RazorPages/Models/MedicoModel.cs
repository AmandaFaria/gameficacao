using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gameficacao01.RazorPages.Models
{
    public class MedicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MedicoId {get;set;}
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string? NomeMedico {get;set;}
        [Required(ErrorMessage ="Especialidade é obrigatório")]
        public string? EspecialidadeMedico {get;set;}
        [Required(ErrorMessage ="Número de registo profissional é obrigatório")]
        public string? NumRegistro {get;set;}
        [Required(ErrorMessage ="Horário da conulta é obrigatório")]
        public DateTime? HorarioDisponivel {get;set;}
        public List<ConsultaModel> Consultas {get;set;}
    }
}