


using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MercadoWEB.Migrations
{
    public partial class migracionProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<int>(nullable: false),
                    NombreProducto = table.Column<string>(maxLength: 500, nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 2000, nullable: false),
                    Foto = table.Column<byte[]>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
