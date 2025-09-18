namespace Projet___Don_du_Sang
{
    partial class ConsutationDonneur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LstDonneur = new ListBox();
            LblDonneur = new Label();
            BtnReload = new Button();
            GBReponsesDonneurs = new GroupBox();
            LblQuestion = new Label();
            btnQuestionSuivante = new Button();
            btnQuestionPrecedente = new Button();
            textBox1 = new TextBox();
            labPreciser = new Label();
            GbResponses = new GroupBox();
            radiobtnNon = new RadioButton();
            radiobtnOui = new RadioButton();
            radiobtnJeNeSaisPas = new RadioButton();
            GBReponsesDonneurs.SuspendLayout();
            GbResponses.SuspendLayout();
            SuspendLayout();
            // 
            // LstDonneur
            // 
            LstDonneur.FormattingEnabled = true;
            LstDonneur.ItemHeight = 17;
            LstDonneur.Location = new Point(12, 29);
            LstDonneur.Name = "LstDonneur";
            LstDonneur.Size = new Size(269, 174);
            LstDonneur.TabIndex = 0;
            LstDonneur.SelectedIndexChanged += LstDonneur_SelectedIndexChanged;
            LstDonneur.DoubleClick += LstDonneur_DoubleClick;
            // 
            // LblDonneur
            // 
            LblDonneur.AutoSize = true;
            LblDonneur.Location = new Point(12, 9);
            LblDonneur.Name = "LblDonneur";
            LblDonneur.Size = new Size(118, 17);
            LblDonneur.TabIndex = 1;
            LblDonneur.Text = "Liste des donneurs";
            // 
            // BtnReload
            // 
            BtnReload.Location = new Point(12, 209);
            BtnReload.Name = "BtnReload";
            BtnReload.Size = new Size(269, 25);
            BtnReload.TabIndex = 2;
            BtnReload.Text = "Recharger la liste";
            BtnReload.UseVisualStyleBackColor = true;
            // 
            // GBReponsesDonneurs
            // 
            GBReponsesDonneurs.Controls.Add(LblQuestion);
            GBReponsesDonneurs.Controls.Add(btnQuestionSuivante);
            GBReponsesDonneurs.Controls.Add(btnQuestionPrecedente);
            GBReponsesDonneurs.Controls.Add(textBox1);
            GBReponsesDonneurs.Controls.Add(labPreciser);
            GBReponsesDonneurs.Controls.Add(GbResponses);
            GBReponsesDonneurs.Location = new Point(298, 29);
            GBReponsesDonneurs.Name = "GBReponsesDonneurs";
            GBReponsesDonneurs.Size = new Size(806, 194);
            GBReponsesDonneurs.TabIndex = 3;
            GBReponsesDonneurs.TabStop = false;
            GBReponsesDonneurs.Text = "Réponses";
            // 
            // LblQuestion
            // 
            LblQuestion.AutoSize = true;
            LblQuestion.Location = new Point(6, 21);
            LblQuestion.Name = "LblQuestion";
            LblQuestion.Size = new Size(60, 17);
            LblQuestion.TabIndex = 16;
            LblQuestion.Text = "Question";
            // 
            // btnQuestionSuivante
            // 
            btnQuestionSuivante.Location = new Point(430, 150);
            btnQuestionSuivante.Margin = new Padding(2);
            btnQuestionSuivante.Name = "btnQuestionSuivante";
            btnQuestionSuivante.Size = new Size(138, 24);
            btnQuestionSuivante.TabIndex = 15;
            btnQuestionSuivante.Text = "Question suivante";
            btnQuestionSuivante.UseVisualStyleBackColor = true;
            btnQuestionSuivante.Click += btnQuestionSuivante_Click;
            // 
            // btnQuestionPrecedente
            // 
            btnQuestionPrecedente.Location = new Point(260, 150);
            btnQuestionPrecedente.Margin = new Padding(2);
            btnQuestionPrecedente.Name = "btnQuestionPrecedente";
            btnQuestionPrecedente.Size = new Size(138, 24);
            btnQuestionPrecedente.TabIndex = 14;
            btnQuestionPrecedente.Text = "Question précedente";
            btnQuestionPrecedente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 114);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 25);
            textBox1.TabIndex = 13;
            // 
            // labPreciser
            // 
            labPreciser.AutoSize = true;
            labPreciser.Location = new Point(209, 112);
            labPreciser.Margin = new Padding(2, 0, 2, 0);
            labPreciser.Name = "labPreciser";
            labPreciser.Size = new Size(61, 17);
            labPreciser.TabIndex = 12;
            labPreciser.Text = "Préciser :";
            // 
            // GbResponses
            // 
            GbResponses.Controls.Add(radiobtnNon);
            GbResponses.Controls.Add(radiobtnOui);
            GbResponses.Controls.Add(radiobtnJeNeSaisPas);
            GbResponses.Location = new Point(268, 44);
            GbResponses.Margin = new Padding(2);
            GbResponses.Name = "GbResponses";
            GbResponses.Padding = new Padding(2);
            GbResponses.Size = new Size(315, 60);
            GbResponses.TabIndex = 11;
            GbResponses.TabStop = false;
            // 
            // radiobtnNon
            // 
            radiobtnNon.AutoSize = true;
            radiobtnNon.Location = new Point(108, 27);
            radiobtnNon.Margin = new Padding(2);
            radiobtnNon.Name = "radiobtnNon";
            radiobtnNon.Size = new Size(51, 21);
            radiobtnNon.TabIndex = 3;
            radiobtnNon.TabStop = true;
            radiobtnNon.Text = "Non";
            radiobtnNon.UseVisualStyleBackColor = true;
            // 
            // radiobtnOui
            // 
            radiobtnOui.AutoSize = true;
            radiobtnOui.Location = new Point(6, 26);
            radiobtnOui.Margin = new Padding(2);
            radiobtnOui.Name = "radiobtnOui";
            radiobtnOui.Size = new Size(46, 21);
            radiobtnOui.TabIndex = 2;
            radiobtnOui.TabStop = true;
            radiobtnOui.Text = "Oui";
            radiobtnOui.UseVisualStyleBackColor = true;
            // 
            // radiobtnJeNeSaisPas
            // 
            radiobtnJeNeSaisPas.AutoSize = true;
            radiobtnJeNeSaisPas.Location = new Point(210, 27);
            radiobtnJeNeSaisPas.Margin = new Padding(2);
            radiobtnJeNeSaisPas.Name = "radiobtnJeNeSaisPas";
            radiobtnJeNeSaisPas.Size = new Size(107, 21);
            radiobtnJeNeSaisPas.TabIndex = 4;
            radiobtnJeNeSaisPas.TabStop = true;
            radiobtnJeNeSaisPas.Text = "Je ne sais pas";
            radiobtnJeNeSaisPas.UseVisualStyleBackColor = true;
            // 
            // ConsutationDonneur
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 248);
            Controls.Add(GBReponsesDonneurs);
            Controls.Add(BtnReload);
            Controls.Add(LblDonneur);
            Controls.Add(LstDonneur);
            Name = "ConsutationDonneur";
            Text = "ConsutationDonneur";
            GBReponsesDonneurs.ResumeLayout(false);
            GBReponsesDonneurs.PerformLayout();
            GbResponses.ResumeLayout(false);
            GbResponses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstDonneur;
        private Label LblDonneur;
        private Button BtnReload;
        private GroupBox GBReponsesDonneurs;
        private Button btnQuestionSuivante;
        private Button btnQuestionPrecedente;
        private TextBox textBox1;
        private Label labPreciser;
        private GroupBox GbResponses;
        private RadioButton radiobtnNon;
        private RadioButton radiobtnOui;
        private RadioButton radiobtnJeNeSaisPas;
        private Label labQuestionPosee;
        private Label LblQuestion;
    }
}