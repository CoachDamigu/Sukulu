
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class CreateNiveau
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbRanking = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.cbSystemeScolaire = new System.Windows.Forms.ComboBox();
            this.cbEnseignement = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(372, 324);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tbDescription);
            this.pnlBody.Controls.Add(this.tbRanking);
            this.pnlBody.Controls.Add(this.tbName);
            this.pnlBody.Controls.Add(this.tbCode);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 59);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(372, 210);
            this.pnlBody.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(100, 125);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(264, 76);
            this.tbDescription.TabIndex = 7;
            // 
            // tbRanking
            // 
            this.tbRanking.Location = new System.Drawing.Point(100, 89);
            this.tbRanking.Name = "tbRanking";
            this.tbRanking.Size = new System.Drawing.Size(100, 23);
            this.tbRanking.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 23);
            this.tbName.TabIndex = 5;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(100, 15);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 23);
            this.tbCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Rang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Code";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 269);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(372, 55);
            this.pnlFooter.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.flpControls);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(372, 59);
            this.pnlHeader.TabIndex = 2;
            // 
            // flpControls
            // 
            this.flpControls.Controls.Add(this.cbSystemeScolaire);
            this.flpControls.Controls.Add(this.cbEnseignement);
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpControls.Location = new System.Drawing.Point(0, 0);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(311, 57);
            this.flpControls.TabIndex = 0;
            // 
            // cbSystemeScolaire
            // 
            this.cbSystemeScolaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSystemeScolaire.FormattingEnabled = true;
            this.cbSystemeScolaire.Location = new System.Drawing.Point(3, 3);
            this.cbSystemeScolaire.Name = "cbSystemeScolaire";
            this.cbSystemeScolaire.Size = new System.Drawing.Size(308, 23);
            this.cbSystemeScolaire.TabIndex = 0;
            this.cbSystemeScolaire.SelectedIndexChanged += new System.EventHandler(this.cbSystemeScolaire_SelectedIndexChanged);
            // 
            // cbEnseignement
            // 
            this.cbEnseignement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnseignement.FormattingEnabled = true;
            this.cbEnseignement.Location = new System.Drawing.Point(3, 32);
            this.cbEnseignement.Name = "cbEnseignement";
            this.cbEnseignement.Size = new System.Drawing.Size(308, 23);
            this.cbEnseignement.TabIndex = 1;
            this.cbEnseignement.SelectedIndexChanged += new System.EventHandler(this.cbEnseignement_SelectedIndexChanged);
            // 
            // CreateNiveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 324);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateNiveau";
            this.Text = "CreateNiveau";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.flpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.ComboBox cbSystemeScolaire;
        private System.Windows.Forms.ComboBox cbEnseignement;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbRanking;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}