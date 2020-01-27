using System;

namespace SalaDeEstar
{
    class Program
    {
        static void MostrarListaDeCanais(string [] canais)
        {
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.WriteLine("Lista dos canais disponíveis:");
            for (int i = 0; i < canais.Length; i++)
                Console.WriteLine($"{i + 1} - {canais[i]}");
            Console.WriteLine("======================");
            Console.WriteLine();
        }

        static void ListarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Próximo Canal");
            Console.WriteLine("2 - Canal Anterior");
            Console.WriteLine("3 - Ir para o canal especificado");
            Console.WriteLine("4 - Aumentar o volume");
            Console.WriteLine("5 - Diminuir o volume");
            Console.WriteLine("6 - Mostrar dados da TV");
            Console.WriteLine("7 - Listar Canais disponíveis");
            Console.WriteLine("0 - Desligar");
            Console.Write("Informe a opção desejada: ");
        }

        static int PegarOpcao()
        {
            var entrada = Console.ReadLine();
            bool entradaValida = Int32.TryParse(entrada, out var opcao);
            if (!entradaValida)
            {
                Console.WriteLine("Entrada inválida! Tente novamente.");
                return PegarOpcao();
            }
            return opcao;
        }

        static void Run(Controle controle, string[] canais)
        {
            var continuarPrograma = true;
            while (continuarPrograma)
            {
                ListarMenu();
                var opcao = PegarOpcao();
                switch (opcao)
                {
                    case 1:
                        controle.CanalProximo();
                        break;
                    case 2:
                        controle.CanalAnterior();
                        break;
                    case 3:
                        Console.Write("Informe o canal: ");
                        var canalInformado = PegarOpcao();
                        controle.MudarCanalPara(canalInformado);
                        break;
                    case 4:
                        controle.VolumeAumentar();
                        break;
                    case 5:
                        controle.VolumeDiminuir();
                        break;
                    case 6:
                        var display = controle.DisplayInfo();
                        Console.WriteLine(display);
                        break;
                    case 7:
                        MostrarListaDeCanais(canais);
                        break;
                    default:
                        continuarPrograma = false;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            string[] canais = { "Globo", "Telecine", "HBO", "RedeTV" };
            ITelevisao televisao = new Televisao(canais);
            Controle controle = new Controle(televisao);
            MostrarListaDeCanais(canais);
            Run(controle, canais);
            Console.WriteLine();
            Console.WriteLine("Até logo!");
        }
    }
}
