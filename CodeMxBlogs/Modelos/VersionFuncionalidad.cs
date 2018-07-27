using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMxBlogsCore.Modelos
{
    /// <summary>
    /// Clase de la intersección entre las clases VERSIÓN y FUNCIONALIDAD
    /// </summary>
    public class VersionFuncionalidad
    {
        /// <summary>
        /// Llave de la clase versión 
        /// </summary>
        public virtual Version Version { get; set; }
        /// <summary>
        /// Referencia foranea a la tabla Versión 
        /// </summary>
        public Guid VersionRefGuid { get; set; }

        /// <summary>
        /// Llave de la clase funcionalidad 
        /// </summary>
        public virtual Funcionalidad Funcionalidad { get; set; }
        /// <summary>
        /// Referencia foranea a la tabla funcionalidad
        /// </summary>
        public Guid FuncionalidadRefGuid { get; set; }

        /// <summary>
        /// Aqui se mostrarán los cambios que se hayan realizado en una funcionalidad
        /// </summary>
        public string Cambios { get; set; }

        /// <summary>
        /// Propiedad en la que se mostrarán los errores corregidos 
        /// </summary>
        public string ErroresCorregidos { get; set; }

        /// <summary>
        /// Fecha de actualización de una funcionalidad 
        /// </summary>
        public DateTime FechaActualizacion { get; set; }
    }
}
