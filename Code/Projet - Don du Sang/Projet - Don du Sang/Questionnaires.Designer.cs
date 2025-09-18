namespace Projet___Don_du_Sang
{
    partial class Questionnaires
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
            labNumeroQuestion.Location = new Point(398, 4);
            labNumeroQuestion.Margin = new Padding(2, 0, 2, 0);
            labNumeroQuestion.Name = "labNumeroQuestion";
            labNumeroQuestion.Size = new Size(38, 15);
            labNumeroQuestion.TabIndex = 0;
            labNumeroQuestion.Text = "* / 10 ";
            // 
            // labQuestionPosee
            // 
            labQuestionPosee.Location = new Point(11, 28);
            labQuestionPosee.Margin = new Padding(2, 0, 2, 0);
            labQuestionPosee.Name = "labQuestionPosee";
            labQuestionPosee.Size = new Size(425, 44);
            labQuestionPosee.TabIndex = 1;
            labQuestionPosee.Text = "Question * - *********************************************";
            // 
            // radiobtnOui
            // 
            radiobtnOui.AutoSize = true;
            radiobtnOui.Location = new Point(7, 24);
            radiobtnOui.Margin = new Padding(2, 1, 2, 1);
            radiobtnOui.Name = "radiobtnOui";
            radiobtnOui.Size = new Size(44, 19);
            radiobtnOui.TabIndex = 2;
            radiobtnOui.TabStop = true;
            radiobtnOui.Text = "Oui";
            radiobtnOui.UseVisualStyleBackColor = true;
            radiobtnOui.CheckedChanged += radiobtnOui_CheckedChanged;
            // 
            // radiobtnNon
            // 
            radiobtnNon.AutoSize = true;
            radiobtnNon.Location = new Point(109, 25);
            radiobtnNon.Margin = new Padding(2, 1, 2, 1);
            radiobtnNon.Name = "radiobtnNon";
            radiobtnNon.Size = new Size(48, 19);
            radiobtnNon.TabIndex = 3;
            radiobtnNon.TabStop = true;
            radiobtnNon.Text = "Non";
            radiobtnNon.UseVisualStyleBackColor = true;
            radiobtnNon.CheckedChanged += radiobtnNon_CheckedChanged;
            // 
            // radiobtnJeNeSaisPas
            // 
            radiobtnJeNeSaisPas.AutoSize = true;
            radiobtnJeNeSaisPas.Location = new Point(211, 25);
            radiobtnJeNeSaisPas.Margin = new Padding(2, 1, 2, 1);
            radiobtnJeNeSaisPas.Name = "radiobtnJeNeSaisPas";
            radiobtnJeNeSaisPas.Size = new Size(94, 19);
            radiobtnJeNeSaisPas.TabIndex = 4;
            radiobtnJeNeSaisPas.TabStop = true;
            radiobtnJeNeSaisPas.Text = "Je ne sais pas";
            radiobtnJeNeSaisPas.UseVisualStyleBackColor = true;
            radiobtnJeNeSaisPas.CheckedChanged += radiobtnJeNeSaisPas_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radiobtnNon);
            groupBox1.Controls.Add(radiobtnOui);
            groupBox1.Controls.Add(radiobtnJeNeSaisPas);
            groupBox1.Location = new Point(72, 69);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(315, 53);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // textboxPreciser
            // 
            textboxPreciser.Location = new Point(79, 125);
            textboxPreciser.Margin = new Padding(2, 1, 2, 1);
            textboxPreciser.Name = "textboxPreciser";
            textboxPreciser.Size = new Size(338, 23);
            textboxPreciser.TabIndex = 7;
            // 
            // labPreciser
            // 
            labPreciser.AutoSize = true;
            labPreciser.Location = new Point(17, 126);
            labPreciser.Margin = new Padding(2, 0, 2, 0);
            labPreciser.Name = "labPreciser";
            labPreciser.Size = new Size(54, 15);
            labPreciser.TabIndex = 6;
            labPreciser.Text = "Préciser :";
            // 
            // btnQuestionPrecedente
            // 
            btnQuestionPrecedente.Location = new Point(64, 176);
            btnQuestionPrecedente.Margin = new Padding(2, 1, 2, 1);
            btnQuestionPrecedente.Name = "btnQuestionPrecedente";
            btnQuestionPrecedente.Size = new Size(138, 22);
            btnQuestionPrecedente.TabIndex = 8;
            btnQuestionPrecedente.Text = "Question précedente";
            btnQuestionPrecedente.UseVisualStyleBackColor = true;
            btnQuestionPrecedente.Visible = false;
            // 
            // btnQuestionSuivante
            // 
            btnQuestionSuivante.Location = new Point(234, 176);
            btnQuestionSuivante.Margin = new Padding(2, 1, 2, 1);
            btnQuestionSuivante.Name = "btnQuestionSuivante";
            btnQuestionSuivante.Size = new Size(138, 22);
            btnQuestionSuivante.TabIndex = 9;
            btnQuestionSuivante.Text = "Question suivante";
            btnQuestionSuivante.UseVisualStyleBackColor = true;
            btnQuestionSuivante.Click += btnQuestionSuivante_Click;
            // 
            // BtnRetourMenu
            // 
            BtnRetourMenu.Location = new Point(1, 1);
            BtnRetourMenu.Margin = new Padding(2, 1, 2, 1);
            BtnRetourMenu.Name = "BtnRetourMenu";
            BtnRetourMenu.Size = new Size(81, 22);
            BtnRetourMenu.TabIndex = 10;
            BtnRetourMenu.Text = "Retour";
            BtnRetourMenu.UseVisualStyleBackColor = true;
            BtnRetourMenu.Click += BtnRetourMenu_Click;
            // 
            // Questionnaires
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 231);
            Controls.Add(BtnRetourMenu);
            Controls.Add(btnQuestionSuivante);
            Controls.Add(btnQuestionPrecedente);
            Controls.Add(textboxPreciser);
            Controls.Add(labPreciser);
            Controls.Add(groupBox1);
            Controls.Add(labQuestionPosee);
            Controls.Add(labNumeroQuestion);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Questionnaires";
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