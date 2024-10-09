using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Latihan1.Migrations
{
    public partial class penambahancolumnIsActiveinkaryawan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto",
                schema: "dbo",
                table: "MstKaryawan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isActive",
                schema: "dbo",
                table: "MstKaryawan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto",
                schema: "dbo",
                table: "MstKaryawan");

            migrationBuilder.DropColumn(
                name: "isActive",
                schema: "dbo",
                table: "MstKaryawan");
        }
    }
}
