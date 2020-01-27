using System;
using System.Collections;
/*
    1- O que é POO?
    Programação orientada a objetos é um paradigma de desenvolvimento de software, que busca abstrair regras de negócio, casos e uso e entidades do mundo real
    em forma de código. Essas abstrações são chamadas de Objetos/Classes. Este paradigma tem por sustentação 4 pilares: Abstração, Encapsulamento, Polimorfismo e Herança.

    2- O que é Polimorfismo?
    É a capacidade que uma classe tem de sobrescrever o comportamento de suas ancestrais.

    3- O que é Abstração?
    É a capacidade de, através de código, reproduzir as características e comportamentos de uma entidade do mundo real, sejam elas tangíveis (como uma bola, um animal e etc)
    ou intangíveis (como as regras de negócio, processos internos e etc).

    4- O que é encapsulamento?
    É uma técnica que permite que uma classe controle a visibilidade de suas propriedades e a forma como elas serão acessadas ou alteradas.

    5- Quando usar uma classe abstrata ou uma interface?
    Interfaces denotam comportamentos, podendo servir também como contrato entre camadas e forma de enfraquecimento de acoplamento.
    Por outro lado, classes abstratas podem conter métodos e assim servir como classes básicas para frameworks ou concetradora de comportamento padrão, 
    facilitando a implementação de Patterns como Template Method e/ou Strategy.

    6- O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
    -- IDisposable: É utilizada para implementar classes em que os recursos não são gerenciados pelo framework. Ela obriga a implementação do método Dispose();
    -- IComparable: É utilizada para tornar o objeto comparável com outros, definindo ordem de grandeza. Métodos de ordenação, em geral, pedem objetos que implementem 
                    IComparable. Ela pede a implementação do método CompareTo
    -- ICloneable: É utilizado para implementar a cópia de valores em novas instâncias de um objeto. Ela pede a implementação do método Clone;
    -- IEnumerable: É utilizado para tornar possível a iteração em objetos agregadores, expondo o seu enumerador.

    7- Existe herança múltipla (de classe) em C#?
    Não.

*/

namespace exercicio01
{
    class Program
    {
        static void Executador(string label, Action action)
        {
            Console.WriteLine($"=================== {label} ===================");
            action.Invoke();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void ExemploEnumerable()
        {
            Pessoa[] pessoas = { new Pessoa("José", DateTime.Now, 2D), new Pessoa("Maria", DateTime.Now, 1.5) };
            Galera galera = new Galera(pessoas);
            foreach (Pessoa pessoa in galera)
                Console.WriteLine(pessoa.GetNome());
        }
        static void ExemploDispose()
        {
            using (ExemploDispose exemploDispose = new ExemploDispose()) ;
        }

        static void ExemploClone()
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

        static void ExemploComparable()
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
        static void Main(string[] args)
        {
            Console.Clear();
            Executador("Exemplo ICloneable", ExemploClone);
            Executador("Exemplo IComparable", ExemploComparable);
            Executador("Exemplo IDispose", ExemploDispose);
            Executador("Exemplo IEnumerable", ExemploEnumerable);
        }
    }
}
