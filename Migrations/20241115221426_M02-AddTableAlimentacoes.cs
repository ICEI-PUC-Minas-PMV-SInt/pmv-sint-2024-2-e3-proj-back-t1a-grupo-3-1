using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_1._0_eixo3_2024.Migrations
{
    /// <inheritdoc />
    public partial class M02AddTableAlimentacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentacoes",
                columns: table => new
                {
                    IdAlimentacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraAlimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    QuantidadeAlimentacao = table.Column<int>(type: "int", nullable: false),
                    UnidadeMedida = table.Column<int>(type: "int", nullable: false),
                    IdCachorro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacoes", x => x.IdAlimentacao);
                    table.ForeignKey(
                        name: "FK_Alimentacoes_Cachorros_IdCachorro",
                        column: x => x.IdCachorro,
                        principalTable: "Cachorros",
                        principalColumn: "IdCachorro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alimentacoes_IdCachorro",
                table: "Alimentacoes",
                column: "IdCachorro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentacoes");
        }
    }
}
