using POO;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

public class Piece
{

	public int Superficie;
	public string Nom;

	public Piece(int Superficie, string Nom)
	{
		this.Superficie = Superficie;
		this.Nom = Nom;
	}

    public override string ToString()
    {
		string ToString = String.Format("Nom: {0}", this.Nom);
		ToString += String.Format("Superficie: {0}m²", this.Superficie);
		return ToString;
    }
}
