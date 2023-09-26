using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gameficacao01.RazorPages.Models
{
    public class EspecialidadeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? EspecialidadeId {get;set;}
        [Required(ErrorMessage ="Nome da especialidade é obrigatório")]
        public string? NomeEspecialidade {get;set;}
        [Required(ErrorMessage ="Descrição da especialidade é obrigatório")]
        public string? DescricaoEspecialidade {get;set;}
        public List<MedicoModel> Medicos {get;set;}
        
    }
}