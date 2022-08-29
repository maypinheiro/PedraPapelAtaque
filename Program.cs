using System;

namespace PedraPapelAtaque
{
    class Program
    {
        static void Main(string[] args)
        {
            int rodadas =int.Parse(Console.ReadLine());

            for (int i = 0; i < rodadas; i++)
            {
                string jogadorUm = (Console.ReadLine());
                string jogadorDois = (Console.ReadLine());

                if (jogadorUm.Equals("ataque") && jogadorDois.Equals("ataque")) Console.WriteLine("Aniquilacao mutua");
                else if (jogadorUm.Equals("papel") && jogadorDois.Equals("papel")) Console.WriteLine("Ambos venceram");
                else if (jogadorUm.Equals("ataque"))Console.WriteLine("Jogador 1 venceu");
                else if (jogadorDois.Equals("ataque")) Console.WriteLine("Jogador 2 venceu");
                else if (jogadorDois.Equals("papel"))Console.WriteLine("Jogador 1 venceu");
                else if (jogadorUm.Equals("papel")) Console.WriteLine("Jogador 2 venceu");
                else Console.WriteLine("Sem ganhador");

            }
        }
    }
}
