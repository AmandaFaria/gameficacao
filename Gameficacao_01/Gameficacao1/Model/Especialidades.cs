namespace Gameficacao1.Model
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string NomeEspecialidade { get; set; }
        public string Descricao { get; set; }
        public List<Medico> Medicos { get; set; }
    }

}
