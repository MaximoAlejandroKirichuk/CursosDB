using System;

namespace BE
{
    public class Curso
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public bool Activo { get; set; }
        public decimal Costo { get; set; }
        public string Categoria { get; set; }
        public int DuracionHoras { get; set; }


        public Curso(string nombre, string descripcion, DateTime fechaLanzamiento, bool activo, decimal costo, string categoria, int duracionHoras)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaLanzamiento = fechaLanzamiento;
            Activo = activo;
            Costo = costo;
            Categoria = categoria;
            DuracionHoras = duracionHoras;
        }

        public Curso(int id, string nombre, string descripcion, DateTime fechaLanzamiento, bool activo, decimal costo, string categoria, int duracionHoras)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaLanzamiento = fechaLanzamiento;
            Activo = activo;
            Costo = costo;
            Categoria = categoria;
            DuracionHoras = duracionHoras;
        }

        public Curso()
        {

        }
    }
}
