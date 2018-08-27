using System;

namespace eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio da Eleicao!");
            
            Urna urna = new Urna();
            urna.IniciarVotacao();

            Console.WriteLine("Fim da Eleicao");
        }
    }
}
