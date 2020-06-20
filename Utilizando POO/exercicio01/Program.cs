using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Executador("Exemplo ICloneable", ExemploClone);
            Executador("Exemplo IComparable", ExemploComparable);
            Executador("Exemplo IDispose", ExemploDispose);
            Executador("Exemplo IEnumerable", ExemploEnumerable);
        }

        private static void Executador(string label, Action action)
        {
            Console.WriteLine($"=================== {label} ===================");
            action.Invoke();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void ExemploClone()
        {
            Pessoa narutoOriginal = new Pessoa("Naruto Uzumaki", DateTime.Parse("10/10/1710"), 1.66);
            Pessoa narutoJutsuSombra = narutoOriginal.Clone();
            Console.WriteLine($"Nome do Naruto original: {narutoOriginal}");
            Console.WriteLine($"Nome do Naruto clone: {narutoJutsuSombra}");
            Console.WriteLine("---------");

            narutoJutsuSombra.SetNome("Nauruto Clone");
            narutoJutsuSombra.SetDataNascimento(DateTime.Now);
            narutoJutsuSombra.SetAltura(1.65);
            Console.WriteLine($"Nome do Naruto original: {narutoOriginal}");
            Console.WriteLine($"Nome do Naruto clone: {narutoJutsuSombra}");
        }

        private static void ExemploComparable()
        {
            Pessoa pessoaMaisVelha = new Pessoa("Pessoa mais velha", DateTime.Parse("11/12/1984"), 1.73);
            Pessoa pessoaMaisNova = new Pessoa("Pessoa mais nova", DateTime.Parse("12/11/2000"), 1.6);

            var retorno = pessoaMaisVelha.CompareTo(pessoaMaisNova);
            if (retorno == 0)
                Console.WriteLine("Pessoas são iguais");
            if (retorno == 1)
                Console.WriteLine("Pessoa mais nova vem por último");
            if (retorno == -1)
                Console.WriteLine("Pessoa mais velha vem por primeiro");
            Console.WriteLine();

            Console.WriteLine("Mostrando a ordenação em arrays");
            Pessoa[] pessoas = { pessoaMaisNova, pessoaMaisVelha, pessoaMaisNova };
            Console.WriteLine("Mostrando desordenado");
            for (int i = 0; i < pessoas.Length; i++)
                Console.WriteLine($"{i + 1} - {pessoas[i].GetNome()}");

            Console.WriteLine("Mostrando ordenado");
            Array.Sort(pessoas);
            for (int i = 0; i < pessoas.Length; i++)
                Console.WriteLine($"{i + 1} - {pessoas[i].GetNome()}");
        }

        private static void ExemploDispose()
        {
            using (ExemploDispose exemploDispose = new ExemploDispose()) ;
        }

        private static void ExemploEnumerable()
        {
            Pessoa[] pessoas = { new Pessoa("José", DateTime.Now, 2D), new Pessoa("Maria", DateTime.Now, 1.5) };
            Galera galera = new Galera(pessoas);
            foreach (Pessoa pessoa in galera)
                Console.WriteLine(pessoa.GetNome());
        }
    }
}