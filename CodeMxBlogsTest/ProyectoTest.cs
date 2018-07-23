using System;
using System.Diagnostics;
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
    }
}
