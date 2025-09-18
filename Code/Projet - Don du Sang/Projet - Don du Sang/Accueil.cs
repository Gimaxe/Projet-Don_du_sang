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
            Accueil accueil = new Accueil();
            accueil.Close();
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {

        }
    }
}
