﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using revisaoProjeto.Data;

#nullable disable

namespace revisaoProjeto.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20231119004938_segundaMigracao")]
    partial class segundaMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("revisaoProjeto.Models.Humano", b =>
                {
                    b.Property<int>("HumanoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("idade")
                        .HasColumnType("INTEGER");

                    b.HasKey("HumanoId");

                    b.ToTable("Humanos");
                });
#pragma warning restore 612, 618
        }
    }
}
