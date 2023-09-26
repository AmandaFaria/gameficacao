using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gameficacao01.RazorPages.Models
{
    public class RecepcionistaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RecepcionistaId {get;set;}
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string? NomeRecepcionista {get;set;}

        [Required(ErrorMessage ="Sobrenome é obrigatório")]
        public string? SobrenomeRecepcionista {get;set;}
        [Required(ErrorMessage ="Número de identificação é obrigatório")]
        public string? NumeroIdenticacaoRecepcionista {get;set;}
        [Required(ErrorMessage ="Número de telefone é obrigatório")]
        public string? NumeroTelefoneRecepcionista {get;set;}
        public List<ConsultaModel> Consultas {get;set;}
        
    }
}