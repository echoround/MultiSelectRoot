﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelectBoxAPI.Data;

namespace SelectBoxAPI.Migrations
{
    [DbContext(typeof(SelectBoxAPIContext))]
    partial class SelectBoxAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelectBoxAPI.Models.Customer", b =>
                {
                    b.Property<int?>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Agreed")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("CustomerAuth")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SelectBoxAPI.Models.Sector", b =>
                {
                    b.Property<int?>("SectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("SectorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("SectorId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("SelectBoxAPI.Models.Sector", b =>
                {
                    b.HasOne("SelectBoxAPI.Models.Customer", null)
                        .WithMany("Sectors")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("SelectBoxAPI.Models.Customer", b =>
                {
                    b.Navigation("Sectors");
                });
#pragma warning restore 612, 618
        }
    }
}
