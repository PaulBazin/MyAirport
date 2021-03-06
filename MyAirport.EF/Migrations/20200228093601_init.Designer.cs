﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBZN_SSU.MyAirport.EF;

namespace PBZN_SSU.MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200228093601_init")]

   
    partial class init
    {
        /// <summary>
        /// Modèle cible
        /// </summary>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PBZN_SSU.MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Code_Ita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Prioritaire")
                        .HasColumnType("bit");

                    b.Property<string>("Ssur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sta")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("id_Vol")
                        .HasColumnType("int");

                    b.HasKey("BagageId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("PBZN_SSU.MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Des")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dhc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pax")
                        .HasColumnType("int");

                    b.Property<string>("Pkg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });
#pragma warning restore 612, 618
        }
    }
}
