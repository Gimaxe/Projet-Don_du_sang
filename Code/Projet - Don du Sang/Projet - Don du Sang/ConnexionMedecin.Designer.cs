namespace Projet___Don_du_Sang
{
    partial class ConnexionMedecin
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
            btnRetour = new Button();
            texboxMotDePasse = new TextBox();
            btnValiderConnexion = new Button();
            labMotDePasse = new Label();
            labNomConnexion = new Label();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(20, 21);
            btnRetour.Margin = new Padding(4, 4, 4, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(150, 45);
            btnRetour.TabIndex = 11;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // texboxMotDePasse
            // 
            texboxMotDePasse.Location = new Point(206, 109);
            texboxMotDePasse.Margin = new Padding(4, 4, 4, 4);
            texboxMotDePasse.Name = "texboxMotDePasse";
            texboxMotDePasse.PasswordChar = '*';
            texboxMotDePasse.Size = new Size(277, 39);
            texboxMotDePasse.TabIndex = 10;
            // 
            // btnValiderConnexion
            // 
            btnValiderConnexion.Location = new Point(178, 179);
            btnValiderConnexion.Margin = new Padding(4, 4, 4, 4);
            btnValiderConnexion.Name = "btnValiderConnexion";
            btnValiderConnexion.Size = new Size(150, 45);
            btnValiderConnexion.TabIndex = 9;
            btnValiderConnexion.Text = "Connexion";
            btnValiderConnexion.UseVisualStyleBackColor = true;
            btnValiderConnexion.Click += btnValiderConnexion_Click;
            // 
            // labMotDePasse
            // 
            labMotDePasse.AutoSize = true;
            labMotDePasse.Location = new Point(20, 115);
            labMotDePasse.Margin = new Padding(4, 0, 4, 0);
            labMotDePasse.Name = "labMotDePasse";
            labMotDePasse.Size = new Size(170, 32);
            labMotDePasse.TabIndex = 8;
            labMotDePasse.Text = "Mot de passe :";
            // 
            // labNomConnexion
            // 
            labNomConnexion.AutoSize = true;
            labNomConnexion.Location = new Point(178, 53);
            labNomConnexion.Margin = new Padding(4, 0, 4, 0);
            labNomConnexion.Name = "labNomConnexion";
            labNomConnexion.Size = new Size(129, 32);
            labNomConnexion.TabIndex = 7;
            labNomConnexion.Text = "Connexion";
            // 
            // ConnexionMedecin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 245);
            Controls.Add(btnRetour);
            Controls.Add(texboxMotDePasse);
            Controls.Add(btnValiderConnexion);
            Controls.Add(labMotDePasse);
            Controls.Add(labNomConnexion);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ConnexionMedecin";
            Text = "Espace Medecin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetour;
        private TextBox texboxMotDePasse;
        private Button btnValiderConnexion;
        private Label labMotDePasse;
        private Label labNomConnexion;
    }
}