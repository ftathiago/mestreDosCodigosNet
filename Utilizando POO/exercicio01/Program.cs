using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Hello World!");
            Pessoa[] pessoas = { new Pessoa("José", DateTime.Now, 2D), new Pessoa("Maria", DateTime.Now, 1.5) };
            Galera galera = new Galera(pessoas);
            foreach (Pessoa pessoa in galera)
            {
                Console.WriteLine(pessoa.GetNome());
            }

        }
    }
}
