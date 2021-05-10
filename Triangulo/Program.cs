using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o lado X do triângulo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDigite o lado Y do triângulo");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDigite o lado Z do triângulo");
                int z = Convert.ToInt32(Console.ReadLine());

                Triangulo triangulo = new Triangulo(x, y, z);

                if (triangulo.ValidaTriangulo())
                {
                    Console.Clear();
                    Console.WriteLine("O triângulo é : " + triangulo.VerificaTipo());                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Triângulo inválido!\n");                    
                }
                continue;
            }
        }
    }
}
