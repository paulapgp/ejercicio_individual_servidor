using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servidor.Modelo
{
    public class Entrada
    {
        public long Id { get; set; }
        public double Precio { get; set; }
        public int Sala { get; set; }
        public int Fila { get; set; }
        public int Butaca { get; set; }
        //public DateTime FechaEmision { get; set; }
        public string Pelicula { get; set; }

        public Entrada()
        { }

        public Entrada(double _precio, int _sala, int _fila, int _butaca, string _pelicula)
        {
            this.Precio = _precio;
            this.Sala = _sala;
            this.Fila = _fila;
            this.Butaca = _butaca;
            this.Pelicula = _pelicula;
        }
    }
}