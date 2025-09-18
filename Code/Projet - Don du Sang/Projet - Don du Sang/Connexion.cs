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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            Questionaires questionaires = new Questionaires();
            questionaires.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
        }
    }
}
