using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SalaDeEstar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] canais = { "Globo", "Telecine", "HBO", "RedeTV" };
            var televisao = new Televisao(canais);
            var controle = new Controle(televisao);
            var interacaoControle = new InteracaoControle(controle);

            controle.MostrarListaDeCanais();
            interacaoControle.Interagir();
            Console.WriteLine();
            Console.WriteLine("Até logo!");
        }
    }
}
