using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sprint3.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComportamentoNegocios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    InteracoesPlataforma = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    FrequenciaUso = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Feedback = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UsoRecursosEspecificos = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComportamentoNegocios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesempenhoFinanceiro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Receita = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Lucro = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    Crescimento = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesempenhoFinanceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TendenciasGastos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ano = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    GastoMarketing = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    GastoAutomacao = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TendenciasGastos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComportamentoNegocios");

            migrationBuilder.DropTable(
                name: "DesempenhoFinanceiro");

            migrationBuilder.DropTable(
                name: "TendenciasGastos");
        }
    }
}
