﻿// <auto-generated />
using System;
using CodeMxBlogsCore.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeMxBlogsCore.Migrations
{
    [DbContext(typeof(BlogsContexto))]
    [Migration("20180727184836_0.0.0.1")]
    partial class _0001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeMxBlogsCore.Modelos.Proyecto", b =>
                {
                    b.Property<Guid>("ProyectoGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("UltimaActualizacion");

                    b.HasKey("ProyectoGuid");

                    b.ToTable("Proyecto");
                });
#pragma warning restore 612, 618
        }
    }
}
