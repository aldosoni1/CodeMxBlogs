using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeMxBlogsCore.Migrations
{
    public partial class _0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    ProyectoGuid = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    UltimaActualizacion = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.ProyectoGuid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proyecto");
        }
    }
}
