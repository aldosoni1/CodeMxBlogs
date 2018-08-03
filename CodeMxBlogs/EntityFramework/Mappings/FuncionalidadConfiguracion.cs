using System;
using System.Collections.Generic;
using System.Text;
using CodeMxBlogsCore.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeMxBlogsCore.EntityFramework.Mappings
{
    public class FuncionalidadConfiguracion : IEntityTypeConfiguration<Funcionalidad>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Funcionalidad> builder)
        {
            builder.HasKey(k => k.FuncionalidadGuid);
            builder.Property(p => p.FuncionalidadGuid).ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Descripcion).IsRequired().HasColumnType("nvarchar(max)");
            builder.Property(p => p.PreRequisitos).IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}
