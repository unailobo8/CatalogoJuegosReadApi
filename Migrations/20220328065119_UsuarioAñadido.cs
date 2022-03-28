﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoJuegosApi.Migrations
{
    public partial class UsuarioAñadido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogoJuegos",
                columns: table => new
                {
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    short_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    game_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plataform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    freetogame_profile_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    screenshots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    os = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    memory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    graphics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoJuegos", x => x.JuegoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotecas",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecas", x => new { x.JuegoId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Bibliotecas_CatalogoJuegos_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "CatalogoJuegos",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bibliotecas_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotecas_UserId",
                table: "Bibliotecas",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bibliotecas");

            migrationBuilder.DropTable(
                name: "CatalogoJuegos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
