using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Latihan1.Migrations
{
    public partial class InitializeAbsensiKaryawan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MstAbsensiKaryawan",
                schema: "dbo",
                columns: table => new
                {
                    AbsensiKaryawanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodeKaryawan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamaKaryawan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TglMasuk = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TglKeluar = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    JamMasuk = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    JamKeluar = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstAbsensiKaryawan", x => x.AbsensiKaryawanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MstAbsensiKaryawan",
                schema: "dbo");
        }
    }
}
