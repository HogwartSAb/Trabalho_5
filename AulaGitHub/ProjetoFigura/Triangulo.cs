using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFigura
{
    class Triangulo
    {
        private double alturaT;
        private double baseT;

        public double AlturaT
        {
            set = alturaT = value; }
        public double BaseT
        {
            set = baseT = value; }

        public double Area()
        {
            return (baseT  alturaT)  2;
        }
    }
}
