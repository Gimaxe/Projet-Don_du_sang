namespace Projet___Don_du_Sang
{
    partial class AccueilDonneurs
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
            btnConnexion = new Button();
            btnInscription = new Button();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(75, 51);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(150, 46);
            btnConnexion.TabIndex = 0;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // btnInscription
            // 
            btnInscription.Location = new Point(289, 51);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(150, 46);
            btnInscription.TabIndex = 1;
            btnInscription.Text = "Inscription";
            btnInscription.UseVisualStyleBackColor = true;
            // 
            // AccueilDonneurs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 148);
            Controls.Add(btnInscription);
            Controls.Add(btnConnexion);
            Name = "AccueilDonneurs";
            Text = "AccueilDonneurs";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnexion;
        private Button btnInscription;
    }
}