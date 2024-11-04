using POO;
using System;

public class Proprietaire
{
	public string Nom;
	public string Prenom;
	public Bien[] Biens = new Bien[0];

	public Proprietaire(string Nom, string Prenom, Bien[] Biens)
	{
		this.Nom = Nom;
		this.Prenom = Prenom;
		this.Biens = Biens;
	}

	private string ListeBiens()
	{
		string bienstexte = "";
		foreach (Bien b in this.Biens) 
		{
			bienstexte += String.Format("- {0} {1} au {2}\n", b.GetType().Name == "Maison" ? "Une" : "Un", b.GetType().Name, b.Adresse);
		};

		return bienstexte;
	}

    public override string ToString()
    {
        string ToString = String.Format("{0} {1} {2}", this.Prenom, this.Nom, this.Biens?.Length != 0 ? "possède\n" : "ne possède aucun bien");
		ToString += this.ListeBiens();

		return ToString;
    }
}
