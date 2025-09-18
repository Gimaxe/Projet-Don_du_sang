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
    public partial class Questionaires : Form
    {
        private List<Question> listeQuestions;


        private int indexQuestionActuelle = 1;

        public Questionaires()
        {
            using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
            int nombreTotalDeQuestions = db.Questions.Count();
            InitializeComponent();

            AfficherQuestion();
        }

        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            AccueilDonneurs accueilDonneurs = new AccueilDonneurs();
            accueilDonneurs.Show();
        }

        private void AfficherQuestion()
        {
            using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
            Question question = db.Questions.SingleOrDefault(o => o.IdQuestion == indexQuestionActuelle);


            labNumeroQuestion.Text = question.Numero.ToString() + " / 15";
            labQuestionPosee.Text = "Question " + question.Numero.ToString() + " - " + question.Enonce.ToString();
            if (question.BesoinPrecision == true)
            {
                labPreciser.Visible = true;
                textboxPreciser.Visible = true;
            }
            else
            {
                labPreciser.Visible = false;
                textboxPreciser.Visible = false;
            }
        }

        private void btnQuestionSuivante_Click(object sender, EventArgs e)
        {
            using DonDuSangRomainMathisContext db = new DonDuSangRomainMathisContext();
            List<Reponse> verifierReponse = db.Reponses.Where(o => o.IdDonneur == Connexion.DonneurConnecte.IdDonneur).ToList();
            foreach (List<Reponse> VeriRep in verifierReponse)
            {
                if (VeriRep != null)
                {
                    db.Reponses.RemoveRange(verifierReponse);

                    db.SaveChanges();
                }
            }


            Reponse reponse = new Reponse();
            //reponse.PrecisionPourMedecin 

            bool? reponseChoisie = false;
            if (radiobtnOui.Checked)
            {
                reponseChoisie = true;
                Question question = db.Questions.SingleOrDefault(o => o.IdQuestion == indexQuestionActuelle);
                if (question.BesoinPrecision == true)
                {
                    reponse.PrecisionPourMedecin = textboxPreciser.Text;
                }
                else
                {
                    reponse.PrecisionPourMedecin= null;
                }
            }
            else if (radiobtnNon.Checked)
            {
                reponseChoisie = false;
            }
            else if (radiobtnJeNeSaisPas.Checked)
            {
                reponseChoisie = null;
            }

            reponse.Reponse1 = reponseChoisie;
            reponse.IdQuestion = indexQuestionActuelle;
            reponse.IdDonneur = Connexion.DonneurConnecte.IdDonneur;

            db.Reponses.Add(reponse);
            db.SaveChanges();

            indexQuestionActuelle++;


            int nombreTotalDeQuestions = db.Questions.Count();
            if (indexQuestionActuelle < nombreTotalDeQuestions)
            {
                AfficherQuestion();
            }
            else
            {
                Close();
            }


        }
    }
}
