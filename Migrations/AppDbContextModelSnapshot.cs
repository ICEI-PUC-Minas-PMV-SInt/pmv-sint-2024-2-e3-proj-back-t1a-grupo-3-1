﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_1._0_eixo3_2024.Models;

#nullable disable

namespace Projeto_1._0_eixo3_2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projeto_1._0_eixo3_2024.Models.Alimentacao", b =>
                {
                    b.Property<int>("IdAlimentacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlimentacao"));

                    b.Property<DateTime>("HoraAlimentacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCachorro")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeAlimentacao")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("int");

                    b.HasKey("IdAlimentacao");

                    b.HasIndex("IdCachorro");

                    b.ToTable("Alimentacoes");
                });

            modelBuilder.Entity("Projeto_1._0_eixo3_2024.Models.Cachorro", b =>
                {
                    b.Property<int>("IdCachorro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCachorro"));

                    b.Property<string>("NascimentoCachorro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCachorro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RacaCachorro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCachorro");

                    b.ToTable("Cachorros");
                });

            modelBuilder.Entity("Projeto_1._0_eixo3_2024.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Projeto_1._0_eixo3_2024.Models.Alimentacao", b =>
                {
                    b.HasOne("Projeto_1._0_eixo3_2024.Models.Cachorro", "Cachorro")
                        .WithMany("Alimentacoes")
                        .HasForeignKey("IdCachorro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cachorro");
                });

            modelBuilder.Entity("Projeto_1._0_eixo3_2024.Models.Cachorro", b =>
                {
                    b.Navigation("Alimentacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
