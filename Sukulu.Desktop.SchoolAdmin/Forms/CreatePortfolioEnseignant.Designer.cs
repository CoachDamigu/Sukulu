
namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    partial class CreatePortfolioEnseignant
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cbSalleClasses = new System.Windows.Forms.ComboBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbMatieres = new System.Windows.Forms.ComboBox();
            this.lblEnseignant = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(235, 344);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cbSalleClasses);
            this.pnlBody.Controls.Add(this.tbNotes);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.dtpEnd);
            this.pnlBody.Controls.Add(this.dtpStart);
            this.pnlBody.Controls.Add(this.cbMatieres);
            this.pnlBody.Controls.Add(this.lblEnseignant);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(235, 306);
            this.pnlBody.TabIndex = 1;
            // 
            // cbSalleClasses
            // 
            this.cbSalleClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleClasses.FormattingEnabled = true;
            this.cbSalleClasses.Location = new System.Drawing.Point(16, 71);
            this.cbSalleClasses.Name = "cbSalleClasses";
            this.cbSalleClasses.Size = new System.Drawing.Size(209, 23);
            this.cbSalleClasses.TabIndex = 8;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(15, 197);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(209, 96);
            this.tbNotes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Début";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(60, 135);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(165, 23);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(60, 104);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(165, 23);
            this.dtpStart.TabIndex = 2;
            // 
            // cbMatieres
            // 
            this.cbMatieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatieres.FormattingEnabled = true;
            this.cbMatieres.Location = new System.Drawing.Point(16, 41);
            this.cbMatieres.Name = "cbMatieres";
            this.cbMatieres.Size = new System.Drawing.Size(209, 23);
            this.cbMatieres.TabIndex = 1;
            this.cbMatieres.SelectedIndexChanged += new System.EventHandler(this.cbMatieres_SelectedIndexChanged);
            // 
            // lblEnseignant
            // 
            this.lblEnseignant.AutoSize = true;
            this.lblEnseignant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnseignant.ForeColor = System.Drawing.Color.Blue;
            this.lblEnseignant.Location = new System.Drawing.Point(16, 12);
            this.lblEnseignant.Name = "lblEnseignant";
            this.lblEnseignant.Size = new System.Drawing.Size(86, 15);
            this.lblEnseignant.TabIndex = 0;
            this.lblEnseignant.Text = "[L\'enseignant]";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 306);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(235, 38);
            this.pnlFooter.TabIndex = 0;
            // 
            // CreatePortfolioEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 344);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreatePortfolioEnseignant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une matière à enseigner à un professeur";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ComboBox cbSalleClasses;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cbMatieres;
        private System.Windows.Forms.Label lblEnseignant;
        private System.Windows.Forms.Panel pnlFooter;
    }
}