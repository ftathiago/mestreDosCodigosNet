using System;

/* 6. Crie uma aplicação, que demonstre a diferença entre REF e OUT. */

namespace exercicio06
{
    class Program
    {
        public static void Main(string[] args)
        {
            var texto = "Conteúdo original";
            DemonstrarMetodoComum(texto);
            MostrarVariavel("DemonstrarMetodoComum", texto);

            //É necessário repetir o modificador na utilização do método
            DemonstrarREF(ref texto);
            MostrarVariavel("DemonstrarREF", texto);

            DemonstrarOut(out texto);
            MostrarVariavel("DemonstrarOut", texto);
        }

        private static void DemonstrarMetodoComum(string texto)
        {
            texto = "Modifico apenas internamente";
            Console.WriteLine("Em um método sem modificador de escopo, as alterações tem valor apenas dentro do escopo: " + texto);
        }

        private static void DemonstrarREF(ref string texto)
        {
            texto = "Modificado por referência";
        }

        private static void DemonstrarOut(out string texto)
        {
            //Se o parâmetro tem o modificar "out", você não consegue utilizar sem atribuição de valor anterior
            // Caso tente, haverá um erro de compilação
            //Console.WriteLine("O que tinha antes: " + texto);
            texto = "Ignorando o que veio na variável";
            //Após a primeira atribuição, é possível utilizar a váriável
            Console.WriteLine("O que tem agora dentro da variável: " + texto);
        }

        static void MostrarVariavel(string nomeMetodo, string valor)
        {
            Console.WriteLine($"Valor da variável após o método \"{nomeMetodo}\": {valor}");
        }
    }
}
