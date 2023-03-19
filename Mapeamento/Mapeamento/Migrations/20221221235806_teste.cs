using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mapeamento.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PESSOA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PESSOA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_CONTA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatadeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false),
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    IdTipoConta = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    TipoContaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CONTA_TB_PESSOA_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "TB_PESSOA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_CONTA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_CONTA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_TIPO_CONTA_TB_CONTA_ContaId",
                        column: x => x.ContaId,
                        principalTable: "TB_CONTA",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTA_PessoaId",
                table: "TB_CONTA",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTA_TipoContaId",
                table: "TB_CONTA",
                column: "TipoContaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TIPO_CONTA_ContaId",
                table: "TB_TIPO_CONTA",
                column: "ContaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTA_TB_TIPO_CONTA_TipoContaId",
                table: "TB_CONTA",
                column: "TipoContaId",
                principalTable: "TB_TIPO_CONTA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTA_TB_PESSOA_PessoaId",
                table: "TB_CONTA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTA_TB_TIPO_CONTA_TipoContaId",
                table: "TB_CONTA");

            migrationBuilder.DropTable(
                name: "TB_PESSOA");

            migrationBuilder.DropTable(
                name: "TB_TIPO_CONTA");

            migrationBuilder.DropTable(
                name: "TB_CONTA");
        }
    }
}
