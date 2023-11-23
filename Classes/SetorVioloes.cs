using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Enums;
using DIP.Interfaces;

namespace DIP.Classes
{
    public class SetorVioloes : IFiltroInstrumentos<Violao>
    {
        private readonly List<Violao> _violoes;

        public SetorVioloes()
        {
            _violoes = new List<Violao>();
        }

        public void Adiciona(Violao entry) => _violoes.Add(entry);
        public IEnumerable<Violao> Filtro(Marcas marcas, ViolaoTipo tipo) => _violoes.Where(x => x.Marcas == marcas && x.ViolaoTipo == tipo);
    }

}