using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servidor.Modelo
{
    public class Pelicula
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Categoria { get; set; }
        //public DateTime FechaEstreno { get; set; }
        public int Duracion { get; set; }
        public string Pais { get; set; }

        public Pelicula()
        {
        }

        public Pelicula(string _nombre, string _director, string _categoria, int _duracion, string _pais)
        {
            this.Nombre = _nombre;
            this.Director = _director;
            this.Categoria = _categoria;
            this.Duracion = _duracion;
            this.Pais = _pais;
        }
    }
}