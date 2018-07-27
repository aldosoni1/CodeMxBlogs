using System;
using Microsoft.EntityFrameworkCore;

namespace CodeMxBlogsCore.EntityFramework.Mappings
{
    public class ProyectoConfiguracion: IEntityTypeConfiguration<Proyecto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Proyecto> builder)
    {
        builder.HasKey(k => k.ProyectoGuid);
        builder.Property(p => p.ClienteGuid).ValueGeneratedOnAdd();
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255);
        builder.Property(p => p.ApellidoPaterno).HasMaxLength(255);
        builder.Property(p => p.ApellidoMaterno).HasMaxLength(255);
        builder.Property(p => p.NombreCompleto).IsRequired().HasMaxLength(765);
        builder.Property(p => p.Sexo).HasMaxLength(2);
        builder.Property(p => p.FechaNacimiento);
        builder.Property(p => p.NumeroIdentificacion).HasMaxLength(50);
        builder.Property(p => p.NombreComercial).HasMaxLength(255);
    }
}
}
