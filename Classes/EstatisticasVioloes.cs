using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Enums;
using DIP.Interfaces;

namespace DIP.Classes
{
    public class EstatisticasVioloes
    {
        private readonly IFiltroInstrumentos<Violao> _filtro;

        public EstatisticasVioloes(IFiltroInstrumentos<Violao> filtro)
        {
            _filtro = filtro;
        }

        public int ContaQuantidadeVioloes(Marcas marcas, ViolaoTipo tipo) => _filtro.Filtro(marcas, tipo).Count();
    }
}