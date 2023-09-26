namespace Gameficacao1.Model
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroIdentificacao { get; set; }
        public string HistoricoMedico { get; set; }
        public List<Consulta> Consultas { get; set; }
    }

}
