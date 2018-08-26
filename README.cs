# eleicao

\\Principal
{
Candidato info = new Candidato();

info.numero = 10000;
info.nome = "eu";

Urna votar = new Urna();
votar.adicionarVoto();
votar.exibirResultado();
}

\\Classe Candidato
class Candidato
{
public int numero;
public string nome;
}

\\Classe Urna
public class Urna
{
public List<Candidato>Candidatos{get;set;}
public Urna(){
Candidatos = new List<Candidato>();
}

int b = 0;
int [] vetor = new int[10];
foreach (Candidato a in Candidatos)
{vetor[b] = a.numero;
b++;}

int [] votos = new int[10];
int totalvotos = 0;
public void adicionarVoto()
{do
{Console.WriteLine("Eleições 2018 - Total de votos computados: " + totalvotos);
foreach (Candidato p in Candidatos)
{Console.WriteLine(p.Numero + " " + p.Nome);}
Console.WriteLine("Digite o número do seu candidato: ");
int voto = Console.ReadLine();
for(int i = 0; i < vetor.lenght; i++)
{if(vetor[i]==voto){votos[i]++;
totalvotos++;}
else{return;}}}
 while(voto != -1)

  public void exibirResultado()
 {
  int c = 0;
   Console.WriteLine("Eleições 2018 - Total de votos computados: " + totalvotos);
foreach (Candidato p in Candidatos)
{Console.WriteLine(p.Numero + " " + p.Nome + "votos: " + votos[c]);
c++;}
 Console.WriteLine("Vencedor da eleição - ");
 }
}
