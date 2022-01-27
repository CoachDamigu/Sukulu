
namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    partial class CreateInscription
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblEleve = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAnneeScolaire = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInscriptionDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSelectEleve = new System.Windows.Forms.Button();
            this.cbSalleClasses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.tbMatricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(540, 290);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.lblEleve);
            this.pnlBody.Controls.Add(this.tbNotes);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.lblAnneeScolaire);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.lblInscriptionDate);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 63);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(540, 177);
            this.pnlBody.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Elève à inscrire";
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.ForeColor = System.Drawing.Color.Blue;
            this.lblEleve.Location = new System.Drawing.Point(129, 11);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(86, 15);
            this.lblEleve.TabIndex = 4;
            this.lblEleve.Text = "Nom de l\'élève";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(12, 88);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(522, 83);
            this.tbNotes.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Commentaires";
            // 
            // lblAnneeScolaire
            // 
            this.lblAnneeScolaire.AutoSize = true;
            this.lblAnneeScolaire.ForeColor = System.Drawing.Color.Blue;
            this.lblAnneeScolaire.Location = new System.Drawing.Point(380, 46);
            this.lblAnneeScolaire.Name = "lblAnneeScolaire";
            this.lblAnneeScolaire.Size = new System.Drawing.Size(84, 15);
            this.lblAnneeScolaire.TabIndex = 3;
            this.lblAnneeScolaire.Text = "Année scolaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Année scolaire";
            // 
            // lblInscriptionDate
            // 
            this.lblInscriptionDate.AutoSize = true;
            this.lblInscriptionDate.ForeColor = System.Drawing.Color.Blue;
            this.lblInscriptionDate.Location = new System.Drawing.Point(129, 44);
            this.lblInscriptionDate.Name = "lblInscriptionDate";
            this.lblInscriptionDate.Size = new System.Drawing.Size(31, 15);
            this.lblInscriptionDate.TabIndex = 1;
            this.lblInscriptionDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date d\'inscription";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 240);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(540, 50);
            this.pnlFooter.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnSelectEleve);
            this.pnlHeader.Controls.Add(this.cbSalleClasses);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnVerify);
            this.pnlHeader.Controls.Add(this.tbMatricule);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(540, 63);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnSelectEleve
            // 
            this.btnSelectEleve.Location = new System.Drawing.Point(402, 4);
            this.btnSelectEleve.Name = "btnSelectEleve";
            this.btnSelectEleve.Size = new System.Drawing.Size(132, 24);
            this.btnSelectEleve.TabIndex = 6;
            this.btnSelectEleve.Text = "Sélectionner un élève";
            this.btnSelectEleve.UseVisualStyleBackColor = true;
            this.btnSelectEleve.Click += new System.EventHandler(this.btnSelectEleve_Click);
            // 
            // cbSalleClasses
            // 
            this.cbSalleClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleClasses.FormattingEnabled = true;
            this.cbSalleClasses.Location = new System.Drawing.Point(132, 34);
            this.cbSalleClasses.Name = "cbSalleClasses";
            this.cbSalleClasses.Size = new System.Drawing.Size(129, 23);
            this.cbSalleClasses.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salle de classe";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(267, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(129, 24);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Vérifier le matricule";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbMatricule
            // 
            this.tbMatricule.Location = new System.Drawing.Point(132, 4);
            this.tbMatricule.Name = "tbMatricule";
            this.tbMatricule.Size = new System.Drawing.Size(129, 23);
            this.tbMatricule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule de l\'élève";
            // 
            // CreateInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 290);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer une inscription";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEleve;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAnneeScolaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInscriptionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSelectEleve;
        private System.Windows.Forms.ComboBox cbSalleClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox tbMatricule;
        private System.Windows.Forms.Label label1;
    }
}