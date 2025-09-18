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
    public partial class ConnexionMedecin : Form
    {
        public ConnexionMedecin()
        {
            InitializeComponent();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            if (texboxMotDePasse.Text == "1234")
            {
                ConsutationDonneur consutationDonneur = new ConsutationDonneur();
                consutationDonneur.Show();
                this.Hide();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
            this.Hide();
        }
    }
}
