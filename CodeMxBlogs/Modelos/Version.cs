using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMxBlogsCore.Modelos
{
    /// <summary>
    /// Clase para identificar la version de un proyecto
    /// </summary>
    public class Version
    {
        /// <summary>
        /// Propiedades de clase
        /// </summary>
        public Guid VersionGuid { get; set; }
        public string NombreVersion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Caracteristicas { get; set; }

        /// <summary>
        /// Propiedades de mapeo base de datos
        /// </summary>
        public Proyecto Proyecto { get; set; }
        public Guid ProyectoRefGuid { get; set; }
    }
}
