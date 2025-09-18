using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
                using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
                Donneur donneur = new Donneur();
                donneur.Nom = texboxNom.Text;
                donneur.Prenom = texboxPrenom.Text;
                donneur.AdresseMail = texboxEmail.Text;
                donneur.MotDePasse = HashPassword.Hash(texboxMotDePasse.Text);
                db.Donneurs.Add(donneur);
                db.SaveChanges();
                MessageBox.Show("Inscriprion Réussi !");
                Questionaires questionaires = new Questionaires();
                questionaires.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
                Close();
            }
        }
    }
}
