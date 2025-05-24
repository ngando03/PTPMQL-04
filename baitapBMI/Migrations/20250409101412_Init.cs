using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tinhchisoMBI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "tuoi",
                table: "Persons",
                newName: "Tuoi");

            migrationBuilder.RenameColumn(
                name: "ten",
                table: "Persons",
                newName: "Ten");

            migrationBuilder.RenameColumn(
                name: "donhang3",
                table: "Persons",
                newName: "DonHang3");

            migrationBuilder.RenameColumn(
                name: "donhang2",
                table: "Persons",
                newName: "DonHang2");

            migrationBuilder.RenameColumn(
                name: "donhang1",
                table: "Persons",
                newName: "DonHang1");

            migrationBuilder.RenameColumn(
                name: "diemC",
                table: "Persons",
                newName: "DiemC");

            migrationBuilder.RenameColumn(
                name: "diemB",
                table: "Persons",
                newName: "DiemB");

            migrationBuilder.RenameColumn(
                name: "diemA",
                table: "Persons",
                newName: "DiemA");

            migrationBuilder.RenameColumn(
                name: "chieucao",
                table: "Persons",
                newName: "ChieuCao");

            migrationBuilder.RenameColumn(
                name: "cannang",
                table: "Persons",
                newName: "CanNang");

            migrationBuilder.AlterColumn<int>(
                name: "Tuoi",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ten",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DonHang3",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "BMI",
                table: "Persons",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiemTong",
                table: "Persons",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TongTien",
                table: "Persons",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Ten");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Action",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BMI",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DiemTong",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Tuoi",
                table: "Persons",
                newName: "tuoi");

            migrationBuilder.RenameColumn(
                name: "DonHang3",
                table: "Persons",
                newName: "donhang3");

            migrationBuilder.RenameColumn(
                name: "DonHang2",
                table: "Persons",
                newName: "donhang2");

            migrationBuilder.RenameColumn(
                name: "DonHang1",
                table: "Persons",
                newName: "donhang1");

            migrationBuilder.RenameColumn(
                name: "DiemC",
                table: "Persons",
                newName: "diemC");

            migrationBuilder.RenameColumn(
                name: "DiemB",
                table: "Persons",
                newName: "diemB");

            migrationBuilder.RenameColumn(
                name: "DiemA",
                table: "Persons",
                newName: "diemA");

            migrationBuilder.RenameColumn(
                name: "ChieuCao",
                table: "Persons",
                newName: "chieucao");

            migrationBuilder.RenameColumn(
                name: "CanNang",
                table: "Persons",
                newName: "cannang");

            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "Persons",
                newName: "ten");

            migrationBuilder.AlterColumn<string>(
                name: "tuoi",
                table: "Persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "donhang3",
                table: "Persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ten",
                table: "Persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");
        }
    }
}
