using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMxBlogsCore.Modelos
{
    /// <summary>
    /// Clase que representa proyectos realizados
    /// </summary>
    public class Proyecto
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ProyectoGuid { get; set; }

        /// <summary>
        /// Nombre comercial del proyecto
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }
        /// <summary>
        /// Fecha de la ultima actualizaciòn del proyecto
        /// </summary>
        /// <value>The ultima actualizacion.</value>
        public DateTime UltimaActualizacion { get; set; }

        /// <summary>
        /// Descripcion detallada del proyecto
        /// </summary>
        /// <value>The descripcion.</value>
        public string Descripcion { get; set; }
        //COmentario

        /// <summary>
        ///Reescritura del ToString
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:CodeMxBlogsCore.Modelos.Proyecto"/>.</returns>
        public override string ToString()
        {
            return $"Nombre del Proyecto:{Nombre} Descripcion: {Descripcion} Ultima Fecha de Actualización: {UltimaActualizacion.ToString("dd-MM-yy")}";
        }

        public ICollection<Version> Versiones { get; set; }
    }
}
