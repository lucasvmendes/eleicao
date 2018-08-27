using System;

public class Candidato : IEquatable<Candidato>
{
    public int Numero { get; set; }
    public string Nome { get; set; }

    public Candidato(int numero, string nome)
    {
        Numero = numero;
        Nome = nome;
    }

    public bool Equals(Candidato other)
    {
        return other != null && other.Numero == this.Numero;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Candidato);
    }

    public override int GetHashCode()
    {
        return Numero;
    }
}
