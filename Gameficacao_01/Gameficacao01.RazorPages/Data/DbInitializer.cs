using System.ComponentModel.DataAnnotations;
using Gameficacao01.RazorPages.Models;

namespace Gameficacao01.RazorPages.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Consultas!.Any())
            {
                var consultas = new ConsultaModel[]
                {
                    new ConsultaModel
                    {
                        NomeMedicoConsulta = "José da Silva",
                        NomePacienteConsulta = "Giovana Soares",
                        DataHoraConsulta = DateTime.Parse("2023-11-09 11:30"),
                        TipoConsulta = "Presencial",
                        ObservacoesConsulta = "Alérgica a amedoim"
                    },
                };
                context.AddRange(consultas);
            }

            if (!context.Especialidades!.Any())
            {
                var especialidades = new EspecialidadeModel[]
                {
                    new EspecialidadeModel
                    {
                        NomeEspecialidade = "Nutricionista",
                        DescricaoEspecialidade = "Profissional de saúde especializado em orientar e promover hábitos alimentares saudáveis para melhorar a saúde e o bem-estar de seus pacientes."
                    },
                };
                context.AddRange(especialidades);
            }

            if (!context.Medicos!.Any())
            {
                var medicos = new MedicoModel[]
                {
                    new MedicoModel
                    {
                        NomeMedico = "José da Silva",
                        EspecialidadeMedico = "Nutricionista",
                        NumRegistro ="CRM/SP 123456",
                        HorarioDisponivel = DateTime.Parse("2023-11-09 11:30")
                    },
                };
                context.AddRange(medicos);
            }

            if (!context.Pacientes!.Any())
            {
                var pacientes = new PacienteModel[]
                {
                    new PacienteModel
                    {
                        NomePaciente = "Giovana",
                        SobrenomePaciente = "Soares",
                        NumIdentificacao = "11.223.589-1",
                        HistoricoMedico = "Nenhum histórico no momento"
                    },
                };
                context.AddRange(pacientes);
            }

            if (!context.Recepcionistas!.Any())
            {
                var recepcionistas = new RecepcionistaModel[]
                {
                    new RecepcionistaModel
                    {
                        NomeRecepcionista = "Valéria",
                        SobrenomeRecepcionista = "de Carvalho Melo",
                        NumeroIdenticacaoRecepcionista = "15.485.147-1",
                        NumeroTelefoneRecepcionista = "(45) 99632-4577"
                    },
                };
                context.AddRange(recepcionistas);
            }
            context.SaveChanges();
        }
    }
}