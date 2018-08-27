using System;
using System.Collections.Generic;
using System.Linq;

public class Urna
{
    private List<Candidato> Candidatos { get; set; }
    private Dictionary<Candidato, int> VotosCandidatos { get; set; }
    private int TotalVotos { get; set; }

    public Urna()
    {
        Candidatos = new List<Candidato>();
        VotosCandidatos = new Dictionary<Candidato, int>();
        TotalVotos = 0;

        PreencherCandidatos();
    }

    private void PreencherCandidatos()
    {
        AdicionarCandidato(new Candidato(1, "John Jnow"));
        AdicionarCandidato(new Candidato(2, "Eddard Stark"));
        AdicionarCandidato(new Candidato(3, "Daenerys Targaryen"));
    }

    private void AdicionarCandidato(Candidato candidato)
    {
        Candidatos.Add(candidato);
        VotosCandidatos.Add(candidato, 0);
    }

    public void AdicionarVotoCandidato(Candidato candidato)
    {
        VotosCandidatos[candidato]++;
    }

    public void AdicionarVoto(int voto){
        Candidato candidato = Candidatos.First(c => c.Numero == voto);
        AdicionarVotoCandidato(candidato);
    }

    public bool VerificaVotoValido(int voto){
        return Candidatos.Exists(c => c.Numero == voto);
    }

    public void IniciarVotacao()
    {
        int voto;
        do
        {
            MostrarResultados();

            Console.WriteLine("Digite o número do seu candidato: ");
            voto = int.Parse(Console.ReadLine());

            if(VerificaVotoValido(voto))
                AdicionarVoto(voto);  

        } while (voto != -1);

        ExibirVencedor();
    }

    public void MostrarResultados()
    {
        Console.WriteLine("Eleições 2018 - Total de votos computados: " + TotalVotos);
        foreach (Candidato p in Candidatos)
            Console.WriteLine(p.Numero + " - " + p.Nome);
    }

    public Candidato SelecionarVencedor()
    {
        int maxVotos = VotosCandidatos.Values.Max();
        return VotosCandidatos.First(c => c.Value == maxVotos).Key;
    }

    public void ExibirVencedor()
    {
        Console.WriteLine("Eleições 2018 - Total de votos computados: " + TotalVotos);
        foreach (Candidato p in Candidatos)
            Console.WriteLine(p.Numero + " - " + p.Nome + " - votos: " + VotosCandidatos[p]);

        Candidato vencedor = SelecionarVencedor();
        Console.WriteLine("Vencedor da eleição - " + vencedor.Numero + " - " + vencedor.Nome + " - " + VotosCandidatos[vencedor] + " votos.");
    }
}
