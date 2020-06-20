using System;
using Xunit;
using exercicio04;

namespace AlunoXUnitTest
{
    public class NotaTest
    {
        private const string MATERIA = "Nome da matÃ©ria";
        private const decimal CONCEITO_VALIDO = 5M;
        private const decimal CONCEITO_MAXIMO = 10M;
        private const decimal CONCEITO_MINIMO = 0M;
        private const decimal CONCEITO_INVALIDO_MAIOR = 10.001M;
        private const decimal CONCEITO_INVALIDO_MENOR = 0.0001M;

        [Fact]
        public void ShouldCreateNota()
        {
            Nota nota = new Nota(MATERIA, CONCEITO_VALIDO);

            Assert.NotNull(nota);
        }


        [Fact]
        public void ShouldHaveProperties()
        {
            Nota nota = new Nota(MATERIA, CONCEITO_VALIDO);

            Assert.Equal(MATERIA, nota.Materia);
            Assert.Equal(CONCEITO_VALIDO, nota.Conceito);
        }

        [Theory]
        [InlineData(-0.0001)]
        [InlineData(10.001)]
        public void ShouldNotStoreInvalidConceito(double conceito)
        {
            decimal conceitoDecimal = (decimal)conceito;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    Nota nota = new Nota(MATERIA, conceitoDecimal);
                });
        }
    }
}
