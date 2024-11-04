using POO;
using System;

public class Proprietaire
{
	public string Nom;
	public string Prenom;
	public List<Bien> Biens;

	public Proprietaire(string Nom, string Prenom, List<Bien> Biens)
	{
		this.Nom = Nom;
		this.Prenom = Prenom;
		this.Biens = Biens;
	}

    public override string ToString()
    {
        string ToString = String.Format("Nom: {0}\n", this.Nom);
        ToString += String.Format("Prénom: {0}\n", this.Prenom);
		ToString += "Biens: ";
		foreach (Bien b in this.Biens) 
		{
			ToString += String.Format(b.Adresse);
		}

		return ToString;
    }
}
