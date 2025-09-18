using System;
using System.Collections.Generic;

namespace Projet___Don_du_Sang.Models;

public partial class Reponse
{
    public int IdReponse { get; set; }

    public bool Reponse1 { get; set; }

    public string? PrecisionPourMedecin { get; set; }

    public int IdDonneur { get; set; }

    public int IdQuestion { get; set; }

    public virtual Donneur IdDonneurNavigation { get; set; } = null!;

    public virtual Question IdQuestionNavigation { get; set; } = null!;
}
