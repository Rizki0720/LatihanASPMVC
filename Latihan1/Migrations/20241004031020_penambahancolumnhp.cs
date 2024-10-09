using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Latihan1.Migrations
{
    public partial class penambahancolumnhp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "hp",
                schema: "dbo",
                table: "MstKaryawan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hp",
                schema: "dbo",
                table: "MstKaryawan");
        }
    }
}
