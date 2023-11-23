using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP.Enums;

namespace DIP.Classes
{
    public class Violao
    {
        public string? Nome { get; set; }
        public ViolaoTipo ViolaoTipo { get; set; }
        public Marcas Marcas { get; set; }
    }
}