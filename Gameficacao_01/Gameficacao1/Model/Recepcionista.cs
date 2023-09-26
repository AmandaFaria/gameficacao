namespace Gameficacao1.Model
{
    public class Recepcionista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroIdentificacao { get; set; }
        public string NumeroTelefone { get; set; }
        public List<Consulta> ConsultasGerenciadas { get; set; }
    }

}
