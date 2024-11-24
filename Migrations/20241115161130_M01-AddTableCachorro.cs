using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_1._0_eixo3_2024.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableCachorro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cachorros",
                columns: table => new
                {
                    IdCachorro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCachorro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NascimentoCachorro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RacaCachorro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cachorros", x => x.IdCachorro);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cachorros");
        }
    }
}
