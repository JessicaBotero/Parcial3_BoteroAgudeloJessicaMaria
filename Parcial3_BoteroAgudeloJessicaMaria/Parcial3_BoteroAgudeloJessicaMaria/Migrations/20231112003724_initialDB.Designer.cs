﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial3_BoteroAgudeloJessicaMaria.DAL;

#nullable disable

namespace Parcial3_BoteroAgudeloJessicaMaria.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20231112003724_initialDB")]
    partial class initialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities.EntranceGate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("EntranceGates");
                });

            modelBuilder.Entity("Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("EntranceGateId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EntranceGateId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities.Ticket", b =>
                {
                    b.HasOne("Parcial3_BoteroAgudeloJessicaMaria.DAL.Entities.EntranceGate", "EntranceGate")
                        .WithMany()
                        .HasForeignKey("EntranceGateId");

                    b.Navigation("EntranceGate");
                });
#pragma warning restore 612, 618
        }
    }
}
