using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeMxBlogsCore.Migrations
{
    public partial class _0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionalidad",
                columns: table => new
                {
                    FuncionalidadGuid = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreRequisitos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidad", x => x.FuncionalidadGuid);
                });

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

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    VersionGuid = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    Caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(maxLength: 50, nullable: false),
                    ProyectoGuid1 = table.Column<Guid>(nullable: true),
                    ProyectoGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.VersionGuid);
                    table.ForeignKey(
                        name: "FK_Version_Proyecto_ProyectoGuid",
                        column: x => x.ProyectoGuid,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Version_Proyecto_ProyectoGuid1",
                        column: x => x.ProyectoGuid1,
                        principalTable: "Proyecto",
                        principalColumn: "ProyectoGuid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Version_ProyectoGuid",
                table: "Version",
                column: "ProyectoGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Version_ProyectoGuid1",
                table: "Version",
                column: "ProyectoGuid1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionalidad");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "Proyecto");
        }
    }
}
