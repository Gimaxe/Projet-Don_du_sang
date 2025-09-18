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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
        }

        private void btnValiderInscription_Click(object sender, EventArgs e)
        {
            try
            {
                //using FortBoyardRomainMathisContext db = new FortBoyardRomainMathisContext();
                //Compte compte = new Compte();
                //compte.Nom = Txt_Name.Text;
                //compte.Prenom = Txt_Prenom.Text;
                //compte.Pseudo = Txt_UserName.Text;
                //compte.MotDePasse = Txt_Password.Text;
                //db.Comptes.Add(compte);
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }
    }
}
