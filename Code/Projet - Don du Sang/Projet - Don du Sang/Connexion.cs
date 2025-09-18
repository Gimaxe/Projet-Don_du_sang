using Projet___Don_du_Sang.Models;
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
            try
            {
                this.Hide();
                using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
                Donneur donneur = db.Donneurs.Where(o => o.AdresseMail == texboxEmail.Text && o.MotDePasse == HashPassword.Hash(texboxMotDePasse.Text)).SingleOrDefault();
                if (donneur != null)
                {
                    Questionaires questionaires = new Questionaires();
                    questionaires.Show();
                }
                else
                {
                    MessageBox.Show("Mot de passe non valide");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil.ActiveForm.Show();
        }
    }
}
