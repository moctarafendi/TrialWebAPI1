﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrialWebAPI1.Service;

namespace TrialWebAPI1.Migrations
{
    [DbContext(typeof(PustakaDbContext))]
    partial class PustakaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrialWebAPI1.Entity.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Deskripsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gambar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Judul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Penerbit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Penulis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}