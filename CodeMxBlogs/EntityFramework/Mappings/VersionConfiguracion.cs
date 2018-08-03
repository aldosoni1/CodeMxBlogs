using CodeMxBlogsCore.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CodeMxBlogsCore.EntityFramework.Mappings
{
    public class VersionConfiguracion: IEntityTypeConfiguration<Modelos.Version>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modelos.Version> builder)
        {
            builder.HasKey(k => k.VersionGuid);
            builder.Property(p => p.VersionGuid).ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Numero).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Caracteristicas).IsRequired().HasColumnType("nvarchar(max)");
            builder.Property(p => p.FechaPublicacion).IsRequired();
            builder.HasOne<Proyecto>().WithMany().HasForeignKey(f => f.ProyectoGuid);
        }
    }
}
