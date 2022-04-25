﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatalogoJuegosApi.Migrations
{
    [DbContext(typeof(CatalogoJuegosContext))]
    [Migration("20220425074616_MapeacionDeJuegos")]
    partial class MapeacionDeJuegos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CatalogoJuegosApi.Models.Biblioteca", b =>
                {
                    b.Property<int>("JuegoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("BibliotecaId")
                        .HasColumnType("int");

                    b.HasKey("JuegoId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Biblioteca");
                });

            modelBuilder.Entity("CatalogoJuegosApi.Models.CatalogoJuegos", b =>
                {
                    b.Property<int>("JuegoId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("freetogame_profile_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("game_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("os")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plataform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("release_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("screenshots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("short_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JuegoId");

                    b.ToTable("CatalogoJuegos");
                });

            modelBuilder.Entity("CatalogoJuegosApi.Models.Usuario", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("correo")
                        .IsUnique()
                        .HasFilter("[correo] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CatalogoJuegosApi.Models.Biblioteca", b =>
                {
                    b.HasOne("CatalogoJuegosApi.Models.CatalogoJuegos", "CatalogoJuegos")
                        .WithMany("MisJuegos")
                        .HasForeignKey("JuegoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoJuegosApi.Models.Usuario", "Usuario")
                        .WithMany("MisJuegos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogoJuegos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CatalogoJuegosApi.Models.CatalogoJuegos", b =>
                {
                    b.Navigation("MisJuegos");
                });

            modelBuilder.Entity("CatalogoJuegosApi.Models.Usuario", b =>
                {
                    b.Navigation("MisJuegos");
                });
#pragma warning restore 612, 618
        }
    }
}