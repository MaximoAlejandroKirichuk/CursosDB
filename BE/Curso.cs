using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BE
{
    [Serializable]
    [XmlRoot("Curso")]
    public class Curso
    {
        [XmlElement("IdCurso")]
        public int IdCurso { get; set; }

        [XmlElement("Nombre")]
        public string Nombre { get; set; }

        [XmlElement("Descripcion")]
        public string Descripcion { get; set; }

        [XmlElement("FechaLanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [XmlElement("Activo")]
        public bool Activo { get; set; }

        [XmlElement("Costo")]
        public decimal Costo { get; set; }

        [XmlElement("Categoria")]
        public string Categoria { get; set; }

        [XmlElement("DuracionHoras")]
        public int DuracionHoras { get; set; }

        [XmlArray("Prospectos")]
        [XmlArrayItem("Prospecto")]
        public List<Prospecto> Prospectos { get; set; } = new List<Prospecto>();


        public Curso() { }

        public Curso(string nombre, string descripcion, DateTime fechaLanzamiento, bool activo,
                     decimal costo, string categoria, int duracionHoras)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaLanzamiento = fechaLanzamiento;
            Activo = activo;
            Costo = costo;
            Categoria = categoria;
            DuracionHoras = duracionHoras;
        }

        public Curso(int idCurso, string nombre, string descripcion, DateTime fechaLanzamiento,
                     bool activo, decimal costo, string categoria, int duracionHoras)
        {
            IdCurso = idCurso;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaLanzamiento = fechaLanzamiento;
            Activo = activo;
            Costo = costo;
            Categoria = categoria;
            DuracionHoras = duracionHoras;
        }
    }
}
