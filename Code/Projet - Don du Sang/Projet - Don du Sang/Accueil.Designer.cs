namespace Projet___Don_du_Sang
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMedecin = new Button();
            btnDonneur = new Button();
            labDonDuSang = new Label();
            SuspendLayout();
            // 
            // btnMedecin
            // 
            btnMedecin.Location = new Point(29, 103);
            btnMedecin.Name = "btnMedecin";
            btnMedecin.Size = new Size(150, 46);
            btnMedecin.TabIndex = 0;
            btnMedecin.Text = "Médecins";
            btnMedecin.UseVisualStyleBackColor = true;
            btnMedecin.Click += btnMedecin_Click;
            // 
            // btnDonneur
            // 
            btnDonneur.Location = new Point(300, 103);
            btnDonneur.Name = "btnDonneur";
            btnDonneur.Size = new Size(150, 46);
            btnDonneur.TabIndex = 1;
            btnDonneur.Text = "Donneurs";
            btnDonneur.UseVisualStyleBackColor = true;
            btnDonneur.Click += btnDonneur_Click;
            // 
            // labDonDuSang
            // 
            labDonDuSang.AutoSize = true;
            labDonDuSang.Location = new Point(129, 36);
            labDonDuSang.Name = "labDonDuSang";
            labDonDuSang.Size = new Size(251, 32);
            labDonDuSang.TabIndex = 2;
            labDonDuSang.Text = "Accueil - Don du sang";
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 196);
            Controls.Add(labDonDuSang);
            Controls.Add(btnDonneur);
            Controls.Add(btnMedecin);
            Name = "Accueil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMedecin;
        private Button btnDonneur;
        private Label labDonDuSang;
    }
}
