using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Triangulo
    {
        public double baseTriangulo, alturaTriangulo;

        public double calcularArea()
        {
            return ((this.baseTriangulo * this.alturaTriangulo) / 2);
        }

    }
}
