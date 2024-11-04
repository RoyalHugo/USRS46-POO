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
		string ToString = String.Format("La pièce {0} fait {1}m²\n", this.Nom, this.Superficie);
		return ToString;
    }
}
