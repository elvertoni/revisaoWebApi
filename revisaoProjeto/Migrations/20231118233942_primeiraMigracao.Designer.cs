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
    [Migration("20231118233942_primeiraMigracao")]
    partial class primeiraMigracao
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
                        .IsRequired()
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