// <auto-generated />
using System;
using BlazorApp1.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230130231625_atual")]
    partial class atual
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp1.Server.CartaoPonto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Entrada1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Entrada2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Saida1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Saida2")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CartaoPonto");
                });
#pragma warning restore 612, 618
        }
    }
}
