namespace Projet___Don_du_Sang
{
    partial class Inscription
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
            btnValiderInscription = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            labNom = new Label();
            labPrenom = new Label();
            labEmail = new Label();
            labDateNaissance = new Label();
            labMotDePasse = new Label();
            labNomInscription = new Label();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // btnValiderInscription
            // 
            btnValiderInscription.Location = new Point(254, 372);
            btnValiderInscription.Name = "btnValiderInscription";
            btnValiderInscription.Size = new Size(161, 46);
            btnValiderInscription.TabIndex = 0;
            btnValiderInscription.Text = "Inscription";
            btnValiderInscription.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 39);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(341, 39);
            textBox4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(280, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 5;
            // 
            // labNom
            // 
            labNom.AutoSize = true;
            labNom.Location = new Point(55, 112);
            labNom.Name = "labNom";
            labNom.Size = new Size(79, 32);
            labNom.TabIndex = 6;
            labNom.Text = "Nom :";
            // 
            // labPrenom
            // 
            labPrenom.AutoSize = true;
            labPrenom.Location = new Point(55, 157);
            labPrenom.Name = "labPrenom";
            labPrenom.Size = new Size(109, 32);
            labPrenom.TabIndex = 7;
            labPrenom.Text = "Prenom :";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.Location = new Point(55, 202);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(93, 32);
            labEmail.TabIndex = 8;
            labEmail.Text = "E-mail :";
            // 
            // labDateNaissance
            // 
            labDateNaissance.AutoSize = true;
            labDateNaissance.Location = new Point(55, 249);
            labDateNaissance.Name = "labDateNaissance";
            labDateNaissance.Size = new Size(219, 32);
            labDateNaissance.TabIndex = 9;
            labDateNaissance.Text = "Date de naissance :";
            // 
            // labMotDePasse
            // 
            labMotDePasse.AutoSize = true;
            labMotDePasse.Location = new Point(55, 313);
            labMotDePasse.Name = "labMotDePasse";
            labMotDePasse.Size = new Size(170, 32);
            labMotDePasse.TabIndex = 10;
            labMotDePasse.Text = "Mot de passe :";
            // 
            // labNomInscription
            // 
            labNomInscription.AutoSize = true;
            labNomInscription.Location = new Point(254, 38);
            labNomInscription.Name = "labNomInscription";
            labNomInscription.Size = new Size(125, 32);
            labNomInscription.TabIndex = 11;
            labNomInscription.Text = "Inscription";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(-2, 3);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(150, 46);
            btnRetour.TabIndex = 12;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 454);
            Controls.Add(btnRetour);
            Controls.Add(labNomInscription);
            Controls.Add(labMotDePasse);
            Controls.Add(labDateNaissance);
            Controls.Add(labEmail);
            Controls.Add(labPrenom);
            Controls.Add(labNom);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnValiderInscription);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValiderInscription;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label labNom;
        private Label labPrenom;
        private Label labEmail;
        private Label labDateNaissance;
        private Label labMotDePasse;
        private Label labNomInscription;
        private Button btnRetour;
    }
}