using System;

namespace exercicio06
{
    class Program
    {
        static void DemonstrarMetodoComum(String texto)
        {
            texto = "Modifico apenas internamente";
            Console.WriteLine("Em um método sem modificador de escopo, as alterações tem valor apenas dentro do escopo: " + texto);
        }
        static void DemonstrarREF(ref String texto)
        {
            texto = "Modificado por referência";
        }

        static void DemonstrarOut(out String texto)
        {
            //Se o parâmetro tem o modificar "out", você não consegue utilizar sem atribuição de valor anterior
            // Caso tente, haverá um erro de compilação
            //Console.WriteLine("O que tinha antes: " + texto);
            texto = "Ignorando o que veio na variável";
            //Após a primeira atribuição, é possível utilizar a váriável
            Console.WriteLine("O que tem agora dentro da variável: " + texto);
        }

        static void MostrarVariavel(String nomeMetodo, String valor)
        {
            Console.WriteLine($"Valor da variável após o método \"{nomeMetodo}\": {valor}");
        }
        static void Main(string[] args)
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
    }
}
