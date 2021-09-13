using Microsoft.EntityFrameworkCore.Migrations;

namespace Reservaciones_test.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descripciones_Servicios_ServicioId",
                table: "Descripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Descripciones_T_Habitaciones_T_habitacionId",
                table: "Descripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Destinos_destinoId",
                table: "Reservaciones");

            migrationBuilder.RenameColumn(
                name: "destinoId",
                table: "Reservaciones",
                newName: "DestinoId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservaciones_destinoId",
                table: "Reservaciones",
                newName: "IX_Reservaciones_DestinoId");

            migrationBuilder.RenameColumn(
                name: "T_habitacionId",
                table: "Descripciones",
                newName: "T_HabitacionesId");

            migrationBuilder.RenameColumn(
                name: "ServicioId",
                table: "Descripciones",
                newName: "ServiciosId");

            migrationBuilder.RenameIndex(
                name: "IX_Descripciones_T_habitacionId",
                table: "Descripciones",
                newName: "IX_Descripciones_T_HabitacionesId");

            migrationBuilder.RenameIndex(
                name: "IX_Descripciones_ServicioId",
                table: "Descripciones",
                newName: "IX_Descripciones_ServiciosId");

            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Descripciones_Servicios_ServiciosId",
                table: "Descripciones",
                column: "ServiciosId",
                principalTable: "Servicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Descripciones_T_Habitaciones_T_HabitacionesId",
                table: "Descripciones",
                column: "T_HabitacionesId",
                principalTable: "T_Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Destinos_DestinoId",
                table: "Reservaciones",
                column: "DestinoId",
                principalTable: "Destinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descripciones_Servicios_ServiciosId",
                table: "Descripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Descripciones_T_Habitaciones_T_HabitacionesId",
                table: "Descripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_Destinos_DestinoId",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Reservaciones");

            migrationBuilder.RenameColumn(
                name: "DestinoId",
                table: "Reservaciones",
                newName: "destinoId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservaciones_DestinoId",
                table: "Reservaciones",
                newName: "IX_Reservaciones_destinoId");

            migrationBuilder.RenameColumn(
                name: "T_HabitacionesId",
                table: "Descripciones",
                newName: "T_habitacionId");

            migrationBuilder.RenameColumn(
                name: "ServiciosId",
                table: "Descripciones",
                newName: "ServicioId");

            migrationBuilder.RenameIndex(
                name: "IX_Descripciones_T_HabitacionesId",
                table: "Descripciones",
                newName: "IX_Descripciones_T_habitacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Descripciones_ServiciosId",
                table: "Descripciones",
                newName: "IX_Descripciones_ServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descripciones_Servicios_ServicioId",
                table: "Descripciones",
                column: "ServicioId",
                principalTable: "Servicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Descripciones_T_Habitaciones_T_habitacionId",
                table: "Descripciones",
                column: "T_habitacionId",
                principalTable: "T_Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_Destinos_destinoId",
                table: "Reservaciones",
                column: "destinoId",
                principalTable: "Destinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
