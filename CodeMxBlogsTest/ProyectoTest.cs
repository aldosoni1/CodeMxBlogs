using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using CodeMxBlogsCore.EntityFramework;
using CodeMxBlogsCore.Modelos;
using Xunit;

namespace CodeMxBlogsTest
{
    public class ProyectoTest
    {
        [Fact]
        public void Test1()
        {
            Proyecto proyectoTest = new Proyecto
            {
                ProyectoGuid = new Guid(),
                Nombre = "KioscoChamplitte",
                UltimaActualizacion = new DateTime(2018, 07, 23),
                Descripcion = "Proyecto de kiosco para la empresa champlite"
            };
            Debug.WriteLine(proyectoTest);
        }

        [Fact]
        public void TestMostrarProyectos()
        {
            var lista = new List<Proyecto>();

            using (var contexto = new BlogsContextoFactory().CreateDbContext())
            {
                lista = contexto.Set<Proyecto>().ToList();
            }


            foreach (var proyecto in lista)
            {
                Debug.WriteLine(proyecto.Nombre);
            }
        }

        [Fact]
        public void TestGuardarProyecto()
        {
            var proyectoSofi = new Proyecto
            {
                Nombre = "Champlitte",
                Descripcion = "Un proyecto de Champlitte",
                UltimaActualizacion = new DateTime(2018,07,15)
            };

            using (var contexto = new BlogsContextoFactory().CreateDbContext())
            {
                contexto.Set<Proyecto>().Add(proyectoSofi);
                contexto.SaveChanges();
            }
            
            TestMostrarProyectos();
            
        }
    }
}
