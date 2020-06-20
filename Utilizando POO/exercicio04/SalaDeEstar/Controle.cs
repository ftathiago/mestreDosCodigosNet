using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaDeEstar
{
    public class Controle
    {
        public readonly ITelevisao _televisao;
        public const int BOTAO_CANAL_PROXIMO = 1;
        public const int BOTAO_CANAL_ANTERIOR = 2;
        public const int BOTAO_CANAL_MUDAR_PARA = 3;
        public const int BOTAO_VOLUME_AUMENTAR = 4;
        public const int BOTAO_VOLUME_DIMINUIR = 5;
        public const int BOTAO_DISPLAY_INFO = 6;
        public const int BOTAO_LISTAR_CANAIS = 7;

        public Controle(ITelevisao televisao)
        {
            _televisao = televisao;
        }

        public void MostrarListaDeCanais()
        {
            var canais = _televisao.MostrarCanaisDisponiveis();
            if (!canais.Any())
            {
                Console.WriteLine("Nenhum canal para mostrar");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.WriteLine("Lista dos canais disponíveis:");
            var numeroCanal = 1;
            foreach (var canal in canais)
            {
                Console.WriteLine($"{numeroCanal} - {canal}");
                numeroCanal++;
            }
            Console.WriteLine("======================");
            Console.WriteLine();
            Console.ReadLine();
        }

        public Dictionary<int, Action> PegarControlesMenu()
        {
            var actions = new Dictionary<int, Action>()
            {
                { BOTAO_CANAL_PROXIMO, () => _televisao.CanalProximo() },
                { BOTAO_CANAL_ANTERIOR, () => _televisao.CanalAnterior() },
                { BOTAO_CANAL_MUDAR_PARA, () =>
                    {
                        Console.Write("Informe o canal: ");
                        var canalInformado = PegarOpcao();
                        _televisao.MudarParaCanal(canalInformado);
                    }
                } ,
                { BOTAO_VOLUME_AUMENTAR, () => _televisao.VolumeAumentar() },
                { BOTAO_VOLUME_DIMINUIR, () => _televisao.VolumeDiminuir() },
                { 6, () =>
                    {
                        var display = DisplayInfo();
                        Console.WriteLine(display);
                        Console.ReadLine();
                    }
                },
                { 7, () => MostrarListaDeCanais() }
            };
            return actions;
        }

        public string DisplayInfo()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine();
            displayInfo.AppendLine("+=============================+");
            displayInfo.Append("Você está assistindo: ");
            displayInfo.Append(_televisao.Display());
            displayInfo.AppendLine("+=============================+");
            return displayInfo.ToString();
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
