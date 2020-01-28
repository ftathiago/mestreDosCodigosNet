using exercicio04;
using Xunit;
using System.Collections.Generic;

namespace AlunoXUnitTest
{
    public class AlunoTest
    {
        private const string NOME_ALUNO = "Nome aluno";
        private const string MATERIA = "MatÃ©ria";

        [Fact]
        public void ShouldCreateAluno()
        {
            Aluno aluno = new Aluno(NOME_ALUNO);
            Assert.NotNull(aluno);
            Assert.Equal(NOME_ALUNO, aluno.Nome);
        }

        [Theory]
        [InlineData(10D, 10D, 10D, 10D)]
        [InlineData(10D, 5.5D, 10D, 8.5D)]
        [InlineData(0.01D, 0.01D, 0.01D, 0.01D)]
        public void ShouldCalculteAverageProperly(double conceito1, double conceito2, double conceito3, double mediaEsperada)
        {
            List<Nota> notas = new List<Nota>{
                new Nota(MATERIA, (decimal)conceito1),
                new Nota(MATERIA, (decimal)conceito2),
                new Nota(MATERIA, (decimal)conceito3)
            };
            Aluno aluno = new Aluno(NOME_ALUNO);
            aluno.Notas.AddRange(notas);

            var media = aluno.CalcularMedia();

            Assert.Equal((decimal)mediaEsperada, media);
        }
    }
}