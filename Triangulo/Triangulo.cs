namespace Triangulo
{
    public class Triangulo
    {
        private int x, y, z;
        public Triangulo(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public bool ValidaTriangulo()
        {
            bool validacao = false;

            if (x == 0 || y == 0 || z == 0)
                validacao = false;
            else if (x + y < z || x + z < y || y + z < x) 
                validacao = false;
            else
                validacao = true;

            return validacao;
        }
        public string VerificaTipo()
        {
            string tipoTriangulo = null;

            if (x == y && x == z && y == z)
                tipoTriangulo = "Equilátero\n";
            else if ((x == y & x != z) || (x == z && x != y) || (y == z & x != z))
                tipoTriangulo = "Isósceles\n";
            else
                tipoTriangulo = "Escaleno\n";

            return tipoTriangulo;
        }

    }
}