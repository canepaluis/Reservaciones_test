using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reservaciones_test.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Habitaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Habitaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hoteles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoteles_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinoId = table.Column<int>(type: "int", nullable: false),
                    T_habitacionId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descripciones_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Descripciones_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Descripciones_T_Habitaciones_T_habitacionId",
                        column: x => x.T_habitacionId,
                        principalTable: "T_Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habitaciones_Descripciones_DescripcionId",
                        column: x => x.DescripcionId,
                        principalTable: "Descripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destinoId = table.Column<int>(type: "int", nullable: false),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    habitacionId = table.Column<int>(type: "int", nullable: false),
                    Cantadultos = table.Column<int>(type: "int", nullable: false),
                    Cantmenores = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    HabitacionesId = table.Column<int>(type: "int", nullable: true),
                    HotelesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Destinos_destinoId",
                        column: x => x.destinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Habitaciones_HabitacionesId",
                        column: x => x.HabitacionesId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Habitaciones_habitacionId",
                        column: x => x.habitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Hoteles_HotelesId",
                        column: x => x.HotelesId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Hoteles_hotelId",
                        column: x => x.hotelId,
                        principalTable: "Hoteles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descripciones_DestinoId",
                table: "Descripciones",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Descripciones_ServicioId",
                table: "Descripciones",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Descripciones_T_habitacionId",
                table: "Descripciones",
                column: "T_habitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_DescripcionId",
                table: "Habitaciones",
                column: "DescripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteles_DestinoId",
                table: "Hoteles",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_destinoId",
                table: "Reservaciones",
                column: "destinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_HabitacionesId",
                table: "Reservaciones",
                column: "HabitacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_habitacionId",
                table: "Reservaciones",
                column: "habitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_HotelesId",
                table: "Reservaciones",
                column: "HotelesId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_hotelId",
                table: "Reservaciones",
                column: "hotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservaciones");

            migrationBuilder.DropTable(
                name: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Hoteles");

            migrationBuilder.DropTable(
                name: "Descripciones");

            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "T_Habitaciones");
        }
    }
}
