using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Gameficacao1.Pages
{
    public class Index : PageModel
    {
        public List<MedicoModel> Medicos { get; set; } = new List<MedicoModel>();
        public List<PacienteModel> Pacientes { get; set; } = new List<PacienteModel>();
        public List<RecepcionistaModel> Recepcionistas { get; set; } = new List<RecepcionistaModel>();
        public List<EspecialidadeModel> Especialidades { get; set; } = new List<EspecialidadeModel>();
        public List<ConsultaModel> Consultas { get; set; } = new List<ConsultaModel>();

        public Index()
        {
            // Exemplo de inicialização de listas
            for (int i = 0; i < 10; i++)
            {
                Medicos.Add(new MedicoModel(
                    IdMedico: i,
                    Name: $"Médico {i}",
                    Especialidade: $"Especialidade {i}",
                    numRegistro: $"Registro {i}")
                );

                Pacientes.Add(new PacienteModel(
                    IdPaciente: i,
                    Nome: $"Paciente {i}",
                    Sobrenome: $"Sobrenome {i}",
                    NumeroIdentificacao: $"Identificação {i}",
                    HistoricoMedico: $"Histórico {i}")
                );

                Recepcionistas.Add(new RecepcionistaModel(
                    IdRecepcionista: i,
                    Nome: $"Recepcionista {i}",
                    Sobrenome: $"Sobrenome {i}",
                    NumeroIdentificacao: $"Identificação {i}",
                    NumeroTelefone: $"Telefone {i}")
                );

                Especialidades.Add(new EspecialidadeModel(
                    IdEspecialidade: i,
                    NomeEspecialidade: $"Especialidade {i}",
                    Descricao: $"Descrição {i}")
                );

                Consultas.Add(new ConsultaModel(
                    IdConsulta: i,
                    Medico: Medicos[i],
                    Paciente: Pacientes[i],
                    DataHora: DateTime.Now.AddDays(i), 
                    TipoConsulta: $"Consulta {i}",
                    Observacoes: $"Observações {i}")
                );
            }
        }
    }

    public record MedicoModel(int? IdMedico, string Name, string Especialidade, string numRegistro);
    public record PacienteModel(int? IdPaciente, string Nome, string Sobrenome, string NumeroIdentificacao, string HistoricoMedico);
    public record RecepcionistaModel(int? IdRecepcionista, string Nome, string Sobrenome, string NumeroIdentificacao, string NumeroTelefone);
    public record EspecialidadeModel(int? IdEspecialidade, string NomeEspecialidade, string Descricao);
    public record ConsultaModel(int? IdConsulta, MedicoModel Medico, PacienteModel Paciente, DateTime DataHora, string TipoConsulta, string Observacoes);
}
