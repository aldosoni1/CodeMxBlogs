using System;
using CodeMxBlogsCore.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CodeMxBlogsCore.EntityFramework.Mappings
{
    public class ProyectoConfiguracion: IEntityTypeConfiguration<Proyecto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Proyecto> builder)
        {
            builder.HasKey(k => k.ProyectoGuid);
            builder.Property(p => p.ProyectoGuid).ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(40);
            builder.Property(p => p.Descripcion).IsRequired().HasColumnType("nvarchar(max)");
            builder.Property(p => p.UltimaActualizacion).IsRequired();
            //builder.HasMany(m => m.Versiones).WithOne(m => m.Proyecto);
        }
}
}
