﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroVisitante.Persistence;

#nullable disable

namespace RegistroVisitante.Migrations
{
    [DbContext(typeof(VisitanteContext))]
    [Migration("20240528155831_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RegistroVisitante.Domain.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Bloco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataHoraEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataHoraSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Visitantes");
                });
#pragma warning restore 612, 618
        }
    }
}
