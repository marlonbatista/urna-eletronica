﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrnaEletronica.DAL;

namespace UrnaEletronica.Migrations
{
    [DbContext(typeof(UrnaEletronicaContext))]
    partial class UrnaEletronicaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UrnaEletronica.Model.Candidato", b =>
                {
                    b.Property<int>("IdCandidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Legenda")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeVice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCandidato");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("UrnaEletronica.Model.Voto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDoVoto")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCandidato")
                        .HasColumnType("int");

                    b.Property<bool>("VotoEmBranco")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdCandidato");

                    b.ToTable("Votos");
                });

            modelBuilder.Entity("UrnaEletronica.Model.Voto", b =>
                {
                    b.HasOne("UrnaEletronica.Model.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("IdCandidato");
                });
#pragma warning restore 612, 618
        }
    }
}
