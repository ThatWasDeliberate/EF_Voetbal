﻿// <auto-generated />
using System;
using EF_Voetbal_Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Voetbal_Library.Migrations
{
    [DbContext(typeof(VoetbalContext))]
    [Migration("20200522185356_initialMig")]
    partial class initialMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Voetbal_Library.Speler", b =>
                {
                    b.Property<int>("SpelerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rugnummer")
                        .HasColumnType("int");

                    b.Property<int?>("TeamStamnummer")
                        .HasColumnType("int");

                    b.Property<double>("Waarde")
                        .HasColumnType("float");

                    b.HasKey("SpelerID");

                    b.HasIndex("TeamStamnummer");

                    b.ToTable("Spelers");
                });

            modelBuilder.Entity("EF_Voetbal_Library.Team", b =>
                {
                    b.Property<int>("Stamnummer")
                        .HasColumnType("int");

                    b.Property<string>("Bijnaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trainer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stamnummer");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EF_Voetbal_Library.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NieuwTeamStamnummer")
                        .HasColumnType("int");

                    b.Property<int?>("OudTeamStamnummer")
                        .HasColumnType("int");

                    b.Property<int?>("SpelerID")
                        .HasColumnType("int");

                    b.Property<double>("TransferPrijs")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NieuwTeamStamnummer");

                    b.HasIndex("OudTeamStamnummer");

                    b.HasIndex("SpelerID");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("EF_Voetbal_Library.Speler", b =>
                {
                    b.HasOne("EF_Voetbal_Library.Team", "Team")
                        .WithMany("Spelers")
                        .HasForeignKey("TeamStamnummer");
                });

            modelBuilder.Entity("EF_Voetbal_Library.Transfer", b =>
                {
                    b.HasOne("EF_Voetbal_Library.Team", "NieuwTeam")
                        .WithMany()
                        .HasForeignKey("NieuwTeamStamnummer");

                    b.HasOne("EF_Voetbal_Library.Team", "OudTeam")
                        .WithMany()
                        .HasForeignKey("OudTeamStamnummer");

                    b.HasOne("EF_Voetbal_Library.Speler", "Speler")
                        .WithMany()
                        .HasForeignKey("SpelerID");
                });
#pragma warning restore 612, 618
        }
    }
}
