using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Enums;

namespace DIP.Interfaces
{
    public interface IFiltroInstrumentos<T>
    {
        IEnumerable<T> Filtro(Marcas marcas, ViolaoTipo tipo);
    }
}