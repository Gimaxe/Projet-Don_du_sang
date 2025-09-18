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
            btnRetour.Location = new Point(11, 11);
            btnRetour.Margin = new Padding(2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(81, 24);
            btnRetour.TabIndex = 11;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // texboxMotDePasse
            // 
            texboxMotDePasse.Location = new Point(111, 58);
            texboxMotDePasse.Margin = new Padding(2);
            texboxMotDePasse.Name = "texboxMotDePasse";
            texboxMotDePasse.PasswordChar = '*';
            texboxMotDePasse.Size = new Size(151, 25);
            texboxMotDePasse.TabIndex = 10;
            // 
            // btnValiderConnexion
            // 
            btnValiderConnexion.Location = new Point(96, 95);
            btnValiderConnexion.Margin = new Padding(2);
            btnValiderConnexion.Name = "btnValiderConnexion";
            btnValiderConnexion.Size = new Size(81, 24);
            btnValiderConnexion.TabIndex = 9;
            btnValiderConnexion.Text = "Connexion";
            btnValiderConnexion.UseVisualStyleBackColor = true;
            btnValiderConnexion.Click += btnValiderConnexion_Click;
            // 
            // labMotDePasse
            // 
            labMotDePasse.AutoSize = true;
            labMotDePasse.Location = new Point(11, 61);
            labMotDePasse.Margin = new Padding(2, 0, 2, 0);
            labMotDePasse.Name = "labMotDePasse";
            labMotDePasse.Size = new Size(96, 17);
            labMotDePasse.TabIndex = 8;
            labMotDePasse.Text = "Mot de passe :";
            // 
            // labNomConnexion
            // 
            labNomConnexion.AutoSize = true;
            labNomConnexion.Location = new Point(96, 28);
            labNomConnexion.Margin = new Padding(2, 0, 2, 0);
            labNomConnexion.Name = "labNomConnexion";
            labNomConnexion.Size = new Size(69, 17);
            labNomConnexion.TabIndex = 7;
            labNomConnexion.Text = "Connexion";
            // 
            // ConnexionMedecin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 130);
            Controls.Add(btnRetour);
            Controls.Add(texboxMotDePasse);
            Controls.Add(btnValiderConnexion);
            Controls.Add(labMotDePasse);
            Controls.Add(labNomConnexion);
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