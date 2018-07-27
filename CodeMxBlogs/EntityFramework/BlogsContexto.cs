using System;
using System.Collections.Generic;
using System.Text;
using CodeMxBlogsCore.EntityFramework.Mappings;
using CodeMxBlogsCore.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CodeMxBlogsCore.EntityFramework
{
    public class BlogsContexto: DbContext
    {
        public BlogsContexto(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Proyecto>(new ProyectoConfiguracion());
            base.OnModelCreating(modelBuilder);
        }
    }
}
