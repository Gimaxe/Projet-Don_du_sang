namespace Projet___Don_du_Sang
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnDonneur_Click(object sender, EventArgs e)
        {
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
            this.Hide();
        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {
            ConnexionMedecin connexionMedecin = new ConnexionMedecin();
            connexionMedecin.Show();
            this.Hide();
        }
    }
}
