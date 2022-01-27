
namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    partial class CreateCoursPrevu
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
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.cbEnseignant = new System.Windows.Forms.ComboBox();
            this.cbJour = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblSalleClasse = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMatiere
            // 
            this.cbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatiere.FormattingEnabled = true;
            this.cbMatiere.Location = new System.Drawing.Point(7, 35);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(172, 23);
            this.cbMatiere.TabIndex = 1;
            this.cbMatiere.SelectedIndexChanged += new System.EventHandler(this.cbMatiere_SelectedIndexChanged);
            // 
            // cbEnseignant
            // 
            this.cbEnseignant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnseignant.FormattingEnabled = true;
            this.cbEnseignant.Location = new System.Drawing.Point(7, 64);
            this.cbEnseignant.Name = "cbEnseignant";
            this.cbEnseignant.Size = new System.Drawing.Size(172, 23);
            this.cbEnseignant.TabIndex = 2;
            // 
            // cbJour
            // 
            this.cbJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJour.FormattingEnabled = true;
            this.cbJour.Location = new System.Drawing.Point(7, 93);
            this.cbJour.Name = "cbJour";
            this.cbJour.Size = new System.Drawing.Size(172, 23);
            this.cbJour.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(35, 126);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 23);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(231, 126);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(141, 23);
            this.dtpEndDate.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(35, 155);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(144, 23);
            this.dtpStartTime.TabIndex = 6;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(231, 155);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(141, 23);
            this.dtpEndTime.TabIndex = 7;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.lblSalleClasse);
            this.pnlBody.Controls.Add(this.dtpEndTime);
            this.pnlBody.Controls.Add(this.dtpStartTime);
            this.pnlBody.Controls.Add(this.dtpEndDate);
            this.pnlBody.Controls.Add(this.dtpStartDate);
            this.pnlBody.Controls.Add(this.cbJour);
            this.pnlBody.Controls.Add(this.cbEnseignant);
            this.pnlBody.Controls.Add(this.cbMatiere);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(377, 193);
            this.pnlBody.TabIndex = 8;
            // 
            // lblSalleClasse
            // 
            this.lblSalleClasse.AutoSize = true;
            this.lblSalleClasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalleClasse.ForeColor = System.Drawing.Color.Blue;
            this.lblSalleClasse.Location = new System.Drawing.Point(12, 12);
            this.lblSalleClasse.Name = "lblSalleClasse";
            this.lblSalleClasse.Size = new System.Drawing.Size(66, 15);
            this.lblSalleClasse.TabIndex = 8;
            this.lblSalleClasse.Text = "SalleClasse";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 193);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(377, 43);
            this.pnlFooter.TabIndex = 9;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(377, 236);
            this.pnlMain.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "au";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "De";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "à";
            // 
            // CreateCoursPrevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 236);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateCoursPrevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateCoursPrevu";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMatiere;
        private System.Windows.Forms.ComboBox cbEnseignant;
        private System.Windows.Forms.ComboBox cbJour;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSalleClasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}