using System;
using System.Collections.Generic;
using System.Text;

namespace SalaDeEstar
{
    class InteracaoControle
    {
        private Controle _controle;

        public InteracaoControle(Controle controle)
        {
            _controle = controle;
        }

        public void Interagir()
        {
            var continuarPrograma = true;

            while (continuarPrograma)
            {
                Console.Clear();
                Console.WriteLine(_controle.DisplayInfo());

                var entradaUsuario = PegarEntradaUsuario();
                if (entradaUsuario == 0)
                    break;

                var acoes = _controle.PegarControlesMenu();
                var acaoExiste = acoes.TryGetValue(entradaUsuario, out var acao);
                if (acaoExiste)
                    acao();
                else
                    continuarPrograma = false;
            }
        }

        private static int PegarEntradaUsuario()
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
            var opcao = PegarOpcao();
            return opcao;
        }

        private static int PegarOpcao()
        {
            var entrada = Console.ReadLine();
            bool entradaValida = int.TryParse(entrada, out var opcao);
            if (!entradaValida)
            {
                Console.WriteLine("Entrada inválida! Tente novamente.");
                return PegarOpcao();
            }
            return opcao;
        }
    }
}
