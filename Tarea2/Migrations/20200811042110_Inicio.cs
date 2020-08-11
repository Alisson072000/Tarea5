using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea2.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panaderia",
                columns: table => new
                {
                    PanaderiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panaderia", x => x.PanaderiaId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Ingredientes = table.Column<string>(nullable: true),
                    Calorias = table.Column<float>(nullable: false),
                    PanaderiaProductosPanaderiaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Panaderia_PanaderiaProductosPanaderiaId",
                        column: x => x.PanaderiaProductosPanaderiaId,
                        principalTable: "Panaderia",
                        principalColumn: "PanaderiaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductoPanaderia",
                columns: table => new
                {
                    PanaderiaId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoPanaderia", x => new { x.ProductoId, x.PanaderiaId });
                    table.ForeignKey(
                        name: "FK_ProductoPanaderia_Panaderia_PanaderiaId",
                        column: x => x.PanaderiaId,
                        principalTable: "Panaderia",
                        principalColumn: "PanaderiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoPanaderia_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoPanaderia_PanaderiaId",
                table: "ProductoPanaderia",
                column: "PanaderiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PanaderiaProductosPanaderiaId",
                table: "Productos",
                column: "PanaderiaProductosPanaderiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoPanaderia");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Panaderia");
        }
    }
}
