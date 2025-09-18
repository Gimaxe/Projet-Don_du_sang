using System;
using System.Collections.Generic;

namespace Projet___Don_du_Sang.Models;

public partial class Donneur
{
    public int IdDonneur { get; set; }

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string AdresseMail { get; set; } = null!;

    public DateOnly DateDeNaissance { get; set; }

    public string MotDePasse { get; set; } = null!;

    public string EstDaccord { get; set; } = null!;

    public virtual ICollection<Reponse> Reponses { get; set; } = new List<Reponse>();
}
