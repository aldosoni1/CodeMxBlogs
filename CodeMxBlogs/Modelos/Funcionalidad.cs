using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMxBlogsCore.Modelos
{
    public class Funcionalidad
    {
        public Guid FuncionalidadGuid { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        /// <summary>
        /// propiedad en la que se muestra los requisitos necesarios para ejecutar
        /// la funcionalidad
        /// </summary>
        public string PreRequisitos { get; set; }

    }
}
