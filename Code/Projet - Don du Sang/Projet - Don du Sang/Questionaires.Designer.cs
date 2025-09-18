namespace Projet___Don_du_Sang
{
    partial class Questionaires
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
            labNumeroQuestion = new Label();
            labQuestionPosee = new Label();
            radiobtnOui = new RadioButton();
            radiobtnNon = new RadioButton();
            radiobtnJeNeSaisPas = new RadioButton();
            groupBox1 = new GroupBox();
            textboxPreciser = new TextBox();
            labPreciser = new Label();
            btnQuestionPrecedente = new Button();
            btnQuestionSuivante = new Button();
            BtnRetourMenu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labNumeroQuestion
            // 
            labNumeroQuestion.AutoSize = true;
            labNumeroQuestion.Location = new Point(739, 9);
            labNumeroQuestion.Name = "labNumeroQuestion";
            labNumeroQuestion.Size = new Size(80, 32);
            labNumeroQuestion.TabIndex = 0;
            labNumeroQuestion.Text = "* / 10 ";
            // 
            // labQuestionPosee
            // 
            labQuestionPosee.AutoSize = true;
            labQuestionPosee.Location = new Point(52, 112);
            labQuestionPosee.Name = "labQuestionPosee";
            labQuestionPosee.Size = new Size(602, 32);
            labQuestionPosee.TabIndex = 1;
            labQuestionPosee.Text = "Question * - *********************************************";
            // 
            // radiobtnOui
            // 
            radiobtnOui.AutoSize = true;
            radiobtnOui.Location = new Point(13, 51);
            radiobtnOui.Name = "radiobtnOui";
            radiobtnOui.Size = new Size(83, 36);
            radiobtnOui.TabIndex = 2;
            radiobtnOui.TabStop = true;
            radiobtnOui.Text = "Oui";
            radiobtnOui.UseVisualStyleBackColor = true;
            // 
            // radiobtnNon
            // 
            radiobtnNon.AutoSize = true;
            radiobtnNon.Location = new Point(202, 53);
            radiobtnNon.Name = "radiobtnNon";
            radiobtnNon.Size = new Size(91, 36);
            radiobtnNon.TabIndex = 3;
            radiobtnNon.TabStop = true;
            radiobtnNon.Text = "Non";
            radiobtnNon.UseVisualStyleBackColor = true;
            // 
            // radiobtnJeNeSaisPas
            // 
            radiobtnJeNeSaisPas.AutoSize = true;
            radiobtnJeNeSaisPas.Location = new Point(392, 53);
            radiobtnJeNeSaisPas.Name = "radiobtnJeNeSaisPas";
            radiobtnJeNeSaisPas.Size = new Size(189, 36);
            radiobtnJeNeSaisPas.TabIndex = 4;
            radiobtnJeNeSaisPas.TabStop = true;
            radiobtnJeNeSaisPas.Text = "Je ne sais pas";
            radiobtnJeNeSaisPas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radiobtnNon);
            groupBox1.Controls.Add(radiobtnOui);
            groupBox1.Controls.Add(radiobtnJeNeSaisPas);
            groupBox1.Location = new Point(134, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 113);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textboxPreciser
            // 
            textboxPreciser.Location = new Point(146, 266);
            textboxPreciser.Name = "textboxPreciser";
            textboxPreciser.Size = new Size(624, 39);
            textboxPreciser.TabIndex = 7;
            // 
            // labPreciser
            // 
            labPreciser.AutoSize = true;
            labPreciser.Location = new Point(32, 269);
            labPreciser.Name = "labPreciser";
            labPreciser.Size = new Size(108, 32);
            labPreciser.TabIndex = 6;
            labPreciser.Text = "Préciser :";
            // 
            // btnQuestionPrecedente
            // 
            btnQuestionPrecedente.Location = new Point(118, 376);
            btnQuestionPrecedente.Name = "btnQuestionPrecedente";
            btnQuestionPrecedente.Size = new Size(257, 46);
            btnQuestionPrecedente.TabIndex = 8;
            btnQuestionPrecedente.Text = "Question précedente";
            btnQuestionPrecedente.UseVisualStyleBackColor = true;
            btnQuestionPrecedente.Visible = false;
            // 
            // btnQuestionSuivante
            // 
            btnQuestionSuivante.Location = new Point(435, 376);
            btnQuestionSuivante.Name = "btnQuestionSuivante";
            btnQuestionSuivante.Size = new Size(257, 46);
            btnQuestionSuivante.TabIndex = 9;
            btnQuestionSuivante.Text = "Question suivante";
            btnQuestionSuivante.UseVisualStyleBackColor = true;
            btnQuestionSuivante.Click += btnQuestionSuivante_Click;
            // 
            // BtnRetourMenu
            // 
            BtnRetourMenu.Location = new Point(2, 2);
            BtnRetourMenu.Name = "BtnRetourMenu";
            BtnRetourMenu.Size = new Size(150, 46);
            BtnRetourMenu.TabIndex = 10;
            BtnRetourMenu.Text = "Retour";
            BtnRetourMenu.UseVisualStyleBackColor = true;
            BtnRetourMenu.Click += BtnRetourMenu_Click;
            // 
            // Questionaires
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 493);
            Controls.Add(BtnRetourMenu);
            Controls.Add(btnQuestionSuivante);
            Controls.Add(btnQuestionPrecedente);
            Controls.Add(textboxPreciser);
            Controls.Add(labPreciser);
            Controls.Add(groupBox1);
            Controls.Add(labQuestionPosee);
            Controls.Add(labNumeroQuestion);
            Name = "Questionaires";
            Text = "Questionaires";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labNumeroQuestion;
        private Label labQuestionPosee;
        private RadioButton radiobtnOui;
        private RadioButton radiobtnNon;
        private RadioButton radiobtnJeNeSaisPas;
        private GroupBox groupBox1;
        private Label labPreciser;
        private TextBox textboxPreciser;
        private Button btnQuestionPrecedente;
        private Button btnQuestionSuivante;
        private Button BtnRetourMenu;
    }
}