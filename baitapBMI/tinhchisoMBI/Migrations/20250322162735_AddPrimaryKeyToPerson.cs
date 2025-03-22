using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tinhchisoMBI.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ten = table.Column<string>(type: "TEXT", nullable: true),
                    tuoi = table.Column<string>(type: "TEXT", nullable: true),
                    chieucao = table.Column<double>(type: "REAL", nullable: false),
                    cannang = table.Column<double>(type: "REAL", nullable: false),
                    diemA = table.Column<int>(type: "INTEGER", nullable: false),
                    diemB = table.Column<int>(type: "INTEGER", nullable: false),
                    diemC = table.Column<int>(type: "INTEGER", nullable: false),
                    donhang1 = table.Column<string>(type: "TEXT", nullable: false),
                    donhang2 = table.Column<string>(type: "TEXT", nullable: false),
                    donhang3 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
