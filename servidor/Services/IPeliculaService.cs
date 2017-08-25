using servidor.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servidor.Services
{
    public interface IPeliculaService
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Delete(long id);
        IQueryable<Pelicula> ReadAll();
        Pelicula Read(long id);
        void Update(Pelicula pelicula);
    }
}
