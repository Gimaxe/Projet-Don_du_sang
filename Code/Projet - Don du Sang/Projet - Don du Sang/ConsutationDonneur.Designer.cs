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
            // ConsutationDonneur
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnReload);
            Controls.Add(LblDonneur);
            Controls.Add(LstDonneur);
            Name = "ConsutationDonneur";
            Text = "ConsutationDonneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstDonneur;
        private Label LblDonneur;
        private Button BtnReload;
    }
}