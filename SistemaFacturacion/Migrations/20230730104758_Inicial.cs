using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacionWebApiREST.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    ID_Ciudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Ciu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.ID_Ciudad);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    ID_Empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_Emp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.ID_Empresa);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    ID_Pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Pago = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.ID_Pago);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    ID_Servicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripction_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor_Unit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.ID_Servicio);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Ruc = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_Ciudad = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID_Cliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Ciudad_ID_Ciudad",
                        column: x => x.ID_Ciudad,
                        principalTable: "Ciudad",
                        principalColumn: "ID_Ciudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Empresa = table.Column<int>(type: "int", nullable: false),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Pago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID_Factura);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Empresa_ID_Empresa",
                        column: x => x.ID_Empresa,
                        principalTable: "Empresa",
                        principalColumn: "ID_Empresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Pago_ID_Pago",
                        column: x => x.ID_Pago,
                        principalTable: "Pago",
                        principalColumn: "ID_Pago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Factura",
                columns: table => new
                {
                    ID_Detalle_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Factura = table.Column<int>(type: "int", nullable: false),
                    ID_Servicio = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Pagar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Factura", x => x.ID_Detalle_Factura);
                    table.ForeignKey(
                        name: "FK_Detalle_Factura_Factura_ID_Factura",
                        column: x => x.ID_Factura,
                        principalTable: "Factura",
                        principalColumn: "ID_Factura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Factura_Servicio_ID_Servicio",
                        column: x => x.ID_Servicio,
                        principalTable: "Servicio",
                        principalColumn: "ID_Servicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reembolso",
                columns: table => new
                {
                    ID_Reembolso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Factura = table.Column<int>(type: "int", nullable: false),
                    ID_Servicio = table.Column<int>(type: "int", nullable: false),
                    Descripcion_Re = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reembolso", x => x.ID_Reembolso);
                    table.ForeignKey(
                        name: "FK_Reembolso_Factura_ID_Factura",
                        column: x => x.ID_Factura,
                        principalTable: "Factura",
                        principalColumn: "ID_Factura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reembolso_Servicio_ID_Servicio",
                        column: x => x.ID_Servicio,
                        principalTable: "Servicio",
                        principalColumn: "ID_Servicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ID_Ciudad",
                table: "Cliente",
                column: "ID_Ciudad");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Factura_ID_Factura",
                table: "Detalle_Factura",
                column: "ID_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Factura_ID_Servicio",
                table: "Detalle_Factura",
                column: "ID_Servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ID_Cliente",
                table: "Factura",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ID_Empresa",
                table: "Factura",
                column: "ID_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ID_Pago",
                table: "Factura",
                column: "ID_Pago");

            migrationBuilder.CreateIndex(
                name: "IX_Reembolso_ID_Factura",
                table: "Reembolso",
                column: "ID_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_Reembolso_ID_Servicio",
                table: "Reembolso",
                column: "ID_Servicio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle_Factura");

            migrationBuilder.DropTable(
                name: "Reembolso");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "Ciudad");
        }
    }
}
