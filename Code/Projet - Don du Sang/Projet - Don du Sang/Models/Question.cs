using System;
using System.Collections.Generic;

namespace Projet___Don_du_Sang.Models;

public partial class Question
{
    public int IdQuestion { get; set; }

    public string Numero { get; set; } = null!;

    public string Categorie { get; set; } = null!;

    public string Enonce { get; set; } = null!;

    public bool? EstEliminatoire { get; set; }

    public virtual ICollection<Reponse> Reponses { get; set; } = new List<Reponse>();
}
