using Microsoft.EntityFrameworkCore;
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
    public partial class ConsutationDonneur : Form
    {
        public ConsutationDonneur()
        {
            InitializeComponent();
            using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
            List<Donneur> donneur = db.Donneurs.ToList();
            foreach (Donneur d in donneur)
            {
                LstDonneur.Items.Add(d);
                LstDonneur.DisplayMember = "Nom";
            }

        }

        private int idxQuestionActuelle = 1;
        private void AfficherQuestion()
        {
            using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();

            Question question = db.Questions.SingleOrDefault(o => o.IdQuestion == idxQuestionActuelle);
            LblQuestion.Text = "Question " + question.Numero.ToString() + " - " + question.Enonce.ToString();
        }

        private void LstDonneur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LstDonneur_DoubleClick(object sender, EventArgs e)
        {
            AfficherQuestion();
        }

        private void btnQuestionSuivante_Click(object sender, EventArgs e)
        {
            idxQuestionActuelle++;
            AfficherQuestion();
        }
    }
}
