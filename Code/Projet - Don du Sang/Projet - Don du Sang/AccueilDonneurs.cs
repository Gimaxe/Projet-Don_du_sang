using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet___Don_du_Sang
{
    public partial class AccueilDonneurs : Form
    {
        public AccueilDonneurs()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Close();
            Inscription inscription = new Inscription();
            inscription.Show();

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Close();
            Connexion connexion = new Connexion();
            connexion.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueil.Close();
        }
    }
}
