using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        private int x, y, z;
        public Triangulo(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public bool ValidaTriangulo()
        {
            bool validacao = false;

            if (X == 0 || Y == 0 || Z == 0)
                validacao = false;
            else
                validacao = true;

            return validacao;
        }

        public string VerificaTipo()
        {
            string tipoTriangulo = null;

            if (X == Y && X == Z && Y == Z)
                tipoTriangulo = "Equilátero\n";
            else if ((X == Y & X != Z) || (X == Z && X != Y) || (Y == Z & X != Z))
                tipoTriangulo = "Isosceles\n";
            else
                tipoTriangulo = "Escaleno\n";

            return tipoTriangulo;
        }

    }
}
