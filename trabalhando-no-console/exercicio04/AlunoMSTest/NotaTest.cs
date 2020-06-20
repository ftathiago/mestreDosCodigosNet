using exercicio04;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace AlunoMSTest
{
    [TestClass]
    public class NotaTest
    {
        private const string MATERIA = "Nome da matéria";
        private const decimal CONCEITO_VALIDO = 5M;
        private const decimal CONCEITO_MAXIMO = 10M;
        private const decimal CONCEITO_MINIMO = 0M;
        private const decimal CONCEITO_INVALIDO_MAIOR = 10.001M;
        private const decimal CONCEITO_INVALIDO_MENOR = 0.0001M;

        [TestMethod]
        public void ShouldCreateNota()
        {
            Nota nota = new Nota(MATERIA, CONCEITO_VALIDO);

            Assert.IsNotNull(nota);
        }

        [TestMethod]
        public void ShouldHaveProperties()
        {
            Nota nota = new Nota(MATERIA, CONCEITO_VALIDO);

            Assert.AreEqual(MATERIA, nota.Materia);
            Assert.AreEqual(CONCEITO_VALIDO, nota.Conceito);
        }

        [DataTestMethod]
        [DataRow(-0.0001)]
        [DataRow(10.001)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldNotStoreInvalidConceito(double conceito)
        {
            decimal conceitoDecimal = (decimal)conceito;

            Nota nota = new Nota(MATERIA, conceitoDecimal);
        }
    }
}
