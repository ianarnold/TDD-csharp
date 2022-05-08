using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_tp
{
    public class Calculadora
    {
        public int a { get; set; }
        public int b { get; set; }

        public int Diferenca { get { return a - b; } }
        public int Divisao { get { return a / b; } }
        public int Produto { get { return a * b; } }
        public int Soma { get { return a + b; } }
    }
}
