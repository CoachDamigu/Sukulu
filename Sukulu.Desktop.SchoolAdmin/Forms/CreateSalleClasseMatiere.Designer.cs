
namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    partial class CreateSalleClasseMatiere
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
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCoefficient = new System.Windows.Forms.NumericUpDown();
            this.cbMatieres = new System.Windows.Forms.ComboBox();
            this.lblSalleClasse = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbNotes);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.nudCoefficient);
            this.pnlMain.Controls.Add(this.cbMatieres);
            this.pnlMain.Controls.Add(this.lblSalleClasse);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(277, 235);
            this.pnlMain.TabIndex = 0;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(18, 116);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(247, 73);
            this.tbNotes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coefficient";
            // 
            // nudCoefficient
            // 
            this.nudCoefficient.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCoefficient.Location = new System.Drawing.Point(89, 65);
            this.nudCoefficient.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCoefficient.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCoefficient.Name = "nudCoefficient";
            this.nudCoefficient.ReadOnly = true;
            this.nudCoefficient.Size = new System.Drawing.Size(39, 23);
            this.nudCoefficient.TabIndex = 3;
            this.nudCoefficient.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMatieres
            // 
            this.cbMatieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatieres.FormattingEnabled = true;
            this.cbMatieres.Location = new System.Drawing.Point(18, 36);
            this.cbMatieres.Name = "cbMatieres";
            this.cbMatieres.Size = new System.Drawing.Size(156, 23);
            this.cbMatieres.TabIndex = 2;
            // 
            // lblSalleClasse
            // 
            this.lblSalleClasse.AutoSize = true;
            this.lblSalleClasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalleClasse.ForeColor = System.Drawing.Color.Blue;
            this.lblSalleClasse.Location = new System.Drawing.Point(13, 11);
            this.lblSalleClasse.Name = "lblSalleClasse";
            this.lblSalleClasse.Size = new System.Drawing.Size(74, 15);
            this.lblSalleClasse.TabIndex = 1;
            this.lblSalleClasse.Text = "[SalleClasse]";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 195);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(277, 40);
            this.pnlFooter.TabIndex = 0;
            // 
            // CreateSalleClasseMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 235);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateSalleClasseMatiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Création (Matières enseignées dans une classe)";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefficient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCoefficient;
        private System.Windows.Forms.ComboBox cbMatieres;
        private System.Windows.Forms.Label lblSalleClasse;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label2;
    }
}