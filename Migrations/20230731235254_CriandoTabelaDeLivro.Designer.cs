﻿// <auto-generated />
using System;
using MeusLivrosAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeusLivrosAPI.Migrations
{
    [DbContext(typeof(LivroContext))]
    [Migration("20230731235254_CriandoTabelaDeLivro")]
    partial class CriandoTabelaDeLivro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MeusLivrosAPI.Models.Livro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnoDePublicacao")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Autor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Editora")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Lido")
                        .IsRequired()
                        .HasColumnType("tinyint(1)");

                    b.Property<short?>("Nota")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<int>("QtdPaginas")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}