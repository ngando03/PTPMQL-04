using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tinhchisoMBI.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullForDonHang1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.CreateTable(
                name: "chisoBMI",
                columns: table => new
                {
                    Ten = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    ChieuCao = table.Column<double>(type: "float", nullable: false),
                    CanNang = table.Column<double>(type: "float", nullable: false),
                    DiemA = table.Column<int>(type: "int", nullable: false),
                    DiemB = table.Column<int>(type: "int", nullable: false),
                    DiemC = table.Column<int>(type: "int", nullable: false),
                    DonHang1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonHang2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonHang3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMI = table.Column<double>(type: "float", nullable: true),
                    DiemTong = table.Column<double>(type: "float", nullable: true),
                    TongTien = table.Column<double>(type: "float", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chisoBMI", x => x.Ten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chisoBMI");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    Action = table.Column<string>(type: "TEXT", nullable: false),
                    BMI = table.Column<float>(type: "REAL", nullable: true),
                    CanNang = table.Column<float>(type: "REAL", nullable: false),
                    ChieuCao = table.Column<float>(type: "REAL", nullable: false),
                    DiemA = table.Column<int>(type: "INTEGER", nullable: false),
                    DiemB = table.Column<int>(type: "INTEGER", nullable: false),
                    DiemC = table.Column<int>(type: "INTEGER", nullable: false),
                    DiemTong = table.Column<float>(type: "REAL", nullable: true),
                    DonHang1 = table.Column<string>(type: "TEXT", nullable: false),
                    DonHang2 = table.Column<string>(type: "TEXT", nullable: false),
                    DonHang3 = table.Column<string>(type: "TEXT", nullable: false),
                    TongTien = table.Column<float>(type: "REAL", nullable: true),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chisoBMI", x => x.Id);

                });
        }
    }
}
