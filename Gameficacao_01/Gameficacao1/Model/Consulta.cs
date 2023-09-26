namespace Gameficacao1.Model
{
    public class Consulta
    {
        public int Id { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoConsulta { get; set; }
        public string Observacoes { get; set; }

        public Consulta(int id, Medico medico, Paciente paciente, DateTime data, string tipoconsulta, string observacoes) {

            Id = id;
            Medico = medico;
            Paciente = paciente;
            DataHora = data;
            TipoConsulta = tipoconsulta;
            Observacoes = observacoes;
            
        }
    }

    

}
