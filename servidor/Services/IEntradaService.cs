using servidor.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servidor.Services
{
    public interface IEntradaService
    {
        Entrada Create(Entrada entrada);
        Entrada Delete(long id);
        IQueryable<Entrada> ReadAll();
        Entrada Read(long id);
        void Update(Entrada entrada);
    }
}
