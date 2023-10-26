using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p26_crud_juegos.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    FechaNac = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NoPlayera = table.Column<int>(type: "INTEGER", nullable: false),
                    Posicion = table.Column<string>(type: "TEXT", nullable: false),
                    Apariciones = table.Column<int>(type: "INTEGER", nullable: false),
                    Goles = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugadores");
        }
    }
}
