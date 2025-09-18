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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

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
            //SuspendLayout();
            // 
            // labNumeroQuestion
            // 
            labNumeroQuestion.AutoSize = true;
            labNumeroQuestion.Location = new Point(812, 8);
            labNumeroQuestion.Margin = new Padding(2, 0, 2, 0);
            labNumeroQuestion.Name = "labNumeroQuestion";
            labNumeroQuestion.Size = new Size(44, 17);
            labNumeroQuestion.TabIndex = 0;
            labNumeroQuestion.Text = "* / 10 ";
            // 
            // labQuestionPosee
            // 
            labQuestionPosee.Location = new Point(72, 27);
            labQuestionPosee.Margin = new Padding(2, 0, 2, 0);
            labQuestionPosee.Name = "labQuestionPosee";
            labQuestionPosee.Size = new Size(752, 49);
            labQuestionPosee.TabIndex = 1;
            labQuestionPosee.Text = "Question * - *********************************************";
            // 
            // radiobtnOui
            // 
            radiobtnOui.AutoSize = true;
            radiobtnOui.Location = new Point(7, 27);
            radiobtnOui.Margin = new Padding(2);
            radiobtnOui.Name = "radiobtnOui";
            radiobtnOui.Size = new Size(46, 21);
            radiobtnOui.TabIndex = 2;
            radiobtnOui.TabStop = true;
            radiobtnOui.Text = "Oui";
            radiobtnOui.UseVisualStyleBackColor = true;
            //radiobtnOui.CheckedChanged += radiobtnOui_CheckedChanged;
            // 
            // radiobtnNon
            // 
            radiobtnNon.AutoSize = true;
            radiobtnNon.Location = new Point(348, 27);
            radiobtnNon.Margin = new Padding(2);
            radiobtnNon.Name = "radiobtnNon";
            radiobtnNon.Size = new Size(51, 21);
            radiobtnNon.TabIndex = 3;
            radiobtnNon.TabStop = true;
            radiobtnNon.Text = "Non";
            radiobtnNon.UseVisualStyleBackColor = true;
            //radiobtnNon.CheckedChanged += radiobtnNon_CheckedChanged;
            // 
            // radiobtnJeNeSaisPas
            // 
            radiobtnJeNeSaisPas.AutoSize = true;
            radiobtnJeNeSaisPas.Location = new Point(620, 27);
            radiobtnJeNeSaisPas.Margin = new Padding(2);
            radiobtnJeNeSaisPas.Name = "radiobtnJeNeSaisPas";
            radiobtnJeNeSaisPas.Size = new Size(107, 21);
            radiobtnJeNeSaisPas.TabIndex = 4;
            radiobtnJeNeSaisPas.TabStop = true;
            radiobtnJeNeSaisPas.Text = "Je ne sais pas";
            radiobtnJeNeSaisPas.UseVisualStyleBackColor = true;
            //radiobtnJeNeSaisPas.CheckedChanged += radiobtnJeNeSaisPas_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radiobtnNon);
            groupBox1.Controls.Add(radiobtnOui);
            groupBox1.Controls.Add(radiobtnJeNeSaisPas);
            groupBox1.Location = new Point(72, 78);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(752, 60);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textboxPreciser
            // 
            textboxPreciser.Location = new Point(79, 142);
            textboxPreciser.Margin = new Padding(2);
            textboxPreciser.Multiline = true;
            textboxPreciser.Name = "textboxPreciser";
            textboxPreciser.Size = new Size(745, 83);
            textboxPreciser.TabIndex = 7;
            // 
            // labPreciser
            // 
            labPreciser.AutoSize = true;
            labPreciser.Location = new Point(17, 143);
            labPreciser.Margin = new Padding(2, 0, 2, 0);
            labPreciser.Name = "labPreciser";
            labPreciser.Size = new Size(61, 17);
            labPreciser.TabIndex = 6;
            labPreciser.Text = "Préciser :";
            // 
            // btnQuestionPrecedente
            // 
            btnQuestionPrecedente.Location = new Point(181, 229);
            btnQuestionPrecedente.Margin = new Padding(2);
            btnQuestionPrecedente.Name = "btnQuestionPrecedente";
            btnQuestionPrecedente.Size = new Size(138, 24);
            btnQuestionPrecedente.TabIndex = 8;
            btnQuestionPrecedente.Text = "Question précedente";
            btnQuestionPrecedente.UseVisualStyleBackColor = true;
            btnQuestionPrecedente.Visible = false;
            // 
            // btnQuestionSuivante
            // 
            btnQuestionSuivante.Location = new Point(584, 229);
            btnQuestionSuivante.Margin = new Padding(2);
            btnQuestionSuivante.Name = "btnQuestionSuivante";
            btnQuestionSuivante.Size = new Size(138, 24);
            btnQuestionSuivante.TabIndex = 9;
            btnQuestionSuivante.Text = "Question suivante";
            btnQuestionSuivante.UseVisualStyleBackColor = true;
            //btnQuestionSuivante.Click += btnQuestionSuivante_Click;
            // 
            // BtnRetourMenu
            // 
            BtnRetourMenu.Location = new Point(1, 1);
            BtnRetourMenu.Margin = new Padding(2);
            BtnRetourMenu.Name = "BtnRetourMenu";
            BtnRetourMenu.Size = new Size(81, 24);
            BtnRetourMenu.TabIndex = 10;
            BtnRetourMenu.Text = "Retour";
            BtnRetourMenu.UseVisualStyleBackColor = true;
            //BtnRetourMenu.Click += BtnRetourMenu_Click;
            // 
            // Questionaires
            // 
            //AutoScaleDimensions = new SizeF(7F, 17F);
            //AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(867, 262);
            //Controls.Add(BtnRetourMenu);
            //Controls.Add(btnQuestionSuivante);
            //Controls.Add(btnQuestionPrecedente);
            //Controls.Add(textboxPreciser);
            //Controls.Add(labPreciser);
            //Controls.Add(groupBox1);
            //Controls.Add(labQuestionPosee);
            //Controls.Add(labNumeroQuestion);
            //Margin = new Padding(2);
            //Name = "Questionaires";
            //Text = "Questionaires";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            //ResumeLayout(false);
            //PerformLayout();
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