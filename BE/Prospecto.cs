using System;
using System.Xml.Serialization;

namespace BE
{
    [Serializable]
    [XmlRoot("Prospecto")]
    public class Prospecto
    {
        public Prospecto(int idProspecto, string nombre, int edad, string email, string telefono, string interes, DateTime fechaRegistro, bool contactado, string observaciones, int idCurso)
        {
            IdProspecto = idProspecto;
            Nombre = nombre;
            Edad = edad;
            Email = email;
            Telefono = telefono;
            Interes = interes;
            FechaRegistro = fechaRegistro;
            Contactado = contactado;
            Observaciones = observaciones;
            IdCurso = idCurso;
        }
        public Prospecto(string nombre, int edad, string email, string telefono, string interes, DateTime fechaRegistro, bool contactado, string observaciones, int idCurso)
        {
            Nombre = nombre;
            Edad = edad;
            Email = email;
            Telefono = telefono;
            Interes = interes;
            FechaRegistro = fechaRegistro;
            Contactado = contactado;
            Observaciones = observaciones;
            IdCurso = idCurso;
        }
        public Prospecto()
        {
            
        }

        [XmlElement("IdProspecto")]
        public int IdProspecto { get; set; }

        [XmlElement("Nombre")]
        public string Nombre { get; set; }

        [XmlElement("Edad")]
        public int Edad { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("Telefono")]
        public string Telefono { get; set; }

        [XmlElement("Interes")]
        public string Interes { get; set; }  // En qué curso está interesado

        [XmlElement("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [XmlElement("Contactado")]
        public bool Contactado { get; set; }

        [XmlElement("Observaciones")]
        public string Observaciones { get; set; }

        [XmlElement("IdCurso")]
        public int IdCurso { get; set; }
    }
}
