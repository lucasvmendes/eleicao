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

 \*Armazena o número de cada candidato da lista em um vetor*\
int b = 0;
int [] vetor = new int[10];
foreach (Candidato a in Candidatos)
{vetor[b] = a.numero;
b++;}

 \*vetor votos pra fazer a ligação da quantidade de votos de cada candidato*\
int [] votos = new int[10];
int totalvotos = 0;
public void adicionarVoto()
 \*Vai ficar executando votos e votos até que o usuário vote -1 e acabe a votação*\
{do
{Console.WriteLine("Eleições 2018 - Total de votos computados: " + totalvotos);
 \*Vai imprimir na tela o número e o nome de cada candidato e depois pedir o voto*\
foreach (Candidato p in Candidatos)
{Console.WriteLine(p.Numero + " " + p.Nome);}
Console.WriteLine("Digite o número do seu candidato: ");
int voto = Console.ReadLine();
 \*Verifica se o voto é válido comparando com os números armazenados no vetor e ao mesmo tempo soma o voto de cada candidato em um vetor votos*\
for(int i = 0; i < vetor.lenght; i++)
{if(vetor[i]==voto){votos[i]++;
totalvotos++;}
else{return;}}}
 while(voto != -1)

  public void exibirResultado()
 {
  \*Vai imprimir novamente nome e número dos candidatos e ao lado de cada um os seus votos armazenados no vetor*\
   int c = 0;
   Console.WriteLine("Eleições 2018 - Total de votos computados: " + totalvotos);
foreach (Candidato p in Candidatos)
{Console.WriteLine(p.Numero + " " + p.Nome + "votos: " + votos[c]);
c++;}
  \*Vai comparar quem teve mais votos e imprimir o vencedor*\
 Console.WriteLine("Vencedor da eleição - ");
 }
}
