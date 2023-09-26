using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gameficacao01.RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeMedicoConsulta = table.Column<string>(type: "TEXT", nullable: false),
                    NomePacienteConsulta = table.Column<string>(type: "TEXT", nullable: false),
                    DataHoraConsulta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TipoConsulta = table.Column<string>(type: "TEXT", nullable: false),
                    ObservacoesConsulta = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeEspecialidade = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoEspecialidade = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeMedico = table.Column<string>(type: "TEXT", nullable: false),
                    EspecialidadeMedico = table.Column<string>(type: "TEXT", nullable: false),
                    NumRegistro = table.Column<string>(type: "TEXT", nullable: false),
                    HorarioDisponivel = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomePaciente = table.Column<string>(type: "TEXT", nullable: false),
                    SobrenomePaciente = table.Column<string>(type: "TEXT", nullable: false),
                    NumIdentificacao = table.Column<string>(type: "TEXT", nullable: false),
                    HistoricoMedico = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Recepcionistas",
                columns: table => new
                {
                    RecepcionistaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeRecepcionista = table.Column<string>(type: "TEXT", nullable: false),
                    SobrenomeRecepcionista = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroIdenticacaoRecepcionista = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroTelefoneRecepcionista = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcionistas", x => x.RecepcionistaId);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeMedico",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeMedico", x => new { x.MedicoId, x.EspecialidadeId });
                    table.ForeignKey(
                        name: "FK_EspecialidadeMedico_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeMedico_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoConsulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoConsulta", x => new { x.ConsultaId, x.MedicoId });
                    table.ForeignKey(
                        name: "FK_MedicoConsulta_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoConsulta_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacienteConsulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteConsulta", x => new { x.ConsultaId, x.PacienteId });
                    table.ForeignKey(
                        name: "FK_PacienteConsulta_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacienteConsulta_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecepcionistaConsulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false),
                    RecepcionistaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepcionistaConsulta", x => new { x.ConsultaId, x.RecepcionistaId });
                    table.ForeignKey(
                        name: "FK_RecepcionistaConsulta_Consultas_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consultas",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecepcionistaConsulta_Recepcionistas_RecepcionistaId",
                        column: x => x.RecepcionistaId,
                        principalTable: "Recepcionistas",
                        principalColumn: "RecepcionistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeMedico_EspecialidadeId",
                table: "EspecialidadeMedico",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoConsulta_MedicoId",
                table: "MedicoConsulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteConsulta_PacienteId",
                table: "PacienteConsulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepcionistaConsulta_RecepcionistaId",
                table: "RecepcionistaConsulta",
                column: "RecepcionistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EspecialidadeMedico");

            migrationBuilder.DropTable(
                name: "MedicoConsulta");

            migrationBuilder.DropTable(
                name: "PacienteConsulta");

            migrationBuilder.DropTable(
                name: "RecepcionistaConsulta");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Recepcionistas");
        }
    }
}
