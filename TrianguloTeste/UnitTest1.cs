using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrianguloTeste
{    

using Triangulo;

    [TestClass]
    public class TestesTriangulo1
    {
        [TestMethod]
        public void TesteTipoTriangulo()
        {
            Triangulo trianguloEquilatero = new Triangulo(3, 3, 3);
            Triangulo trianguloEscaleno = new Triangulo(1, 2, 3);
            Triangulo trianguloIsoceles = new Triangulo(3, 2, 3);

            Assert.AreEqual("Equilátero\n", trianguloEquilatero.VerificaTipo());
            Assert.AreEqual("Escaleno\n", trianguloEscaleno.VerificaTipo());
            Assert.AreEqual("Isósceles\n", trianguloIsoceles.VerificaTipo());

        }

        [TestMethod]
        public void TesteTrianguloInvalido()
        {
            Triangulo trianguloInvalido1 = new Triangulo(0, 3, 3);
            Triangulo trianguloInvalido2 = new Triangulo(999999, 2, 3);
            Triangulo trianguloInvalido3 = new Triangulo(0, 23578946, 3);

            Assert.AreEqual(false, trianguloInvalido1.ValidaTriangulo());
            Assert.AreEqual(false, trianguloInvalido2.ValidaTriangulo());
            Assert.AreEqual(false, trianguloInvalido3.ValidaTriangulo());

        }
    }
}
