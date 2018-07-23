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
        /// Propiedades propias de un proyecto
        /// </summary>
        public Guid ProyectoGuid { get; set; }
        public string Nombre { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"Nombre del Proyecto:{Nombre} Descripcion: {Descripcion} Ultima Fecha de Actualización: {UltimaActualizacion.ToString("dd-MM-yy")}";
        }
    }
}
