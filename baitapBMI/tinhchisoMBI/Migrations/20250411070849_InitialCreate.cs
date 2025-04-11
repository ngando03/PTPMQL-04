using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tinhchisoMBI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false),
                    ChieuCao = table.Column<double>(type: "REAL", nullable: false),
                    CanNang = table.Column<double>(type: "REAL", nullable: false),
                    DiemA = table.Column<int>(type: "INTEGER", nullable: false),
                    DiemB = table.Column<int>(type: "INTEGER", nullable: false),
                    DiemC = table.Column<int>(type: "INTEGER", nullable: false),
                    DonHang1 = table.Column<string>(type: "TEXT", nullable: false),
                    DonHang2 = table.Column<string>(type: "TEXT", nullable: false),
                    DonHang3 = table.Column<string>(type: "TEXT", nullable: false),
                    BMI = table.Column<double>(type: "REAL", nullable: true),
                    DiemTong = table.Column<double>(type: "REAL", nullable: true),
                    TongTien = table.Column<double>(type: "REAL", nullable: true),
                    Action = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Ten);
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
