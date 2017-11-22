using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tienda.DataAccess.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    RegistroId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantidadElementos = table.Column<int>(nullable: false),
                    CodigoProducto = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<string>(nullable: false),
                    NombreProducto = table.Column<string>(nullable: true),
                    PrecioMaximo = table.Column<double>(nullable: false),
                    PrecioMinimo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.RegistroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
