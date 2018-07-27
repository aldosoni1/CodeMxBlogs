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
        public string Nombre { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Caracteristicas { get; set; }
        /// <summary>
        /// Este es la propiedad que tiene el nombre de Versionado. Ejemplo: X,Y,Z [1.2.3]
        /// 
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Propiedades de mapeo base de datos
        /// </summary>
        public virtual Proyecto Proyecto { get; set; }
        public Guid ProyectoRefGuid { get; set; }
    }
}
