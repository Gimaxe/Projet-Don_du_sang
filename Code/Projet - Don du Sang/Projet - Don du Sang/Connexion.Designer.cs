namespace Projet___Don_du_Sang
{
    partial class Connexion
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
            labNomConnexion = new Label();
            labEmail = new Label();
            labMotDePasse = new Label();
            btnValiderConnexion = new Button();
            texboxEmail = new TextBox();
            texboxMotDePasse = new TextBox();
            SuspendLayout();
            // 
            // labNomConnexion
            // 
            labNomConnexion.AutoSize = true;
            labNomConnexion.Location = new Point(184, 36);
            labNomConnexion.Name = "labNomConnexion";
            labNomConnexion.Size = new Size(129, 32);
            labNomConnexion.TabIndex = 0;
            labNomConnexion.Text = "Connexion";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.Location = new Point(38, 94);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(93, 32);
            labEmail.TabIndex = 1;
            labEmail.Text = "E-mail :";
            // 
            // labMotDePasse
            // 
            labMotDePasse.AutoSize = true;
            labMotDePasse.Location = new Point(38, 144);
            labMotDePasse.Name = "labMotDePasse";
            labMotDePasse.Size = new Size(170, 32);
            labMotDePasse.TabIndex = 2;
            labMotDePasse.Text = "Mot de passe :";
            // 
            // btnValiderConnexion
            // 
            btnValiderConnexion.Location = new Point(174, 210);
            btnValiderConnexion.Name = "btnValiderConnexion";
            btnValiderConnexion.Size = new Size(150, 46);
            btnValiderConnexion.TabIndex = 3;
            btnValiderConnexion.Text = "Connexion";
            btnValiderConnexion.UseVisualStyleBackColor = true;
            // 
            // texboxEmail
            // 
            texboxEmail.Location = new Point(137, 96);
            texboxEmail.Name = "texboxEmail";
            texboxEmail.Size = new Size(280, 39);
            texboxEmail.TabIndex = 4;
            // 
            // texboxMotDePasse
            // 
            texboxMotDePasse.Location = new Point(221, 141);
            texboxMotDePasse.Name = "texboxMotDePasse";
            texboxMotDePasse.Size = new Size(277, 39);
            texboxMotDePasse.TabIndex = 5;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 298);
            Controls.Add(texboxMotDePasse);
            Controls.Add(texboxEmail);
            Controls.Add(btnValiderConnexion);
            Controls.Add(labMotDePasse);
            Controls.Add(labEmail);
            Controls.Add(labNomConnexion);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labNomConnexion;
        private Label labEmail;
        private Label labMotDePasse;
        private Button btnValiderConnexion;
        private TextBox texboxEmail;
        private TextBox texboxMotDePasse;
    }
}