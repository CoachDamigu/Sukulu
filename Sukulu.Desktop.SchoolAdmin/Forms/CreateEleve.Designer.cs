
namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    partial class CreateEleve
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
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.pbEleve = new System.Windows.Forms.PictureBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.tbOtherNames = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(522, 358);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dtpDOB);
            this.pnlBody.Controls.Add(this.cbSexe);
            this.pnlBody.Controls.Add(this.btnSelectPhoto);
            this.pnlBody.Controls.Add(this.pbEleve);
            this.pnlBody.Controls.Add(this.tbPhone);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.tbEmail);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.tbNotes);
            this.pnlBody.Controls.Add(this.tbOtherNames);
            this.pnlBody.Controls.Add(this.tbFirstName);
            this.pnlBody.Controls.Add(this.tbLastName);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(522, 303);
            this.pnlBody.TabIndex = 12;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(149, 138);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(173, 23);
            this.dtpDOB.TabIndex = 19;
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(149, 109);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(173, 23);
            this.cbSexe.TabIndex = 18;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(336, 21);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(175, 25);
            this.btnSelectPhoto.TabIndex = 17;
            this.btnSelectPhoto.Text = "Ajouter la photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // pbEleve
            // 
            this.pbEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEleve.Location = new System.Drawing.Point(351, 51);
            this.pbEleve.Name = "pbEleve";
            this.pbEleve.Size = new System.Drawing.Size(140, 167);
            this.pbEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEleve.TabIndex = 16;
            this.pbEleve.TabStop = false;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(149, 196);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(173, 23);
            this.tbPhone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Téléphone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(149, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(173, 23);
            this.tbEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(149, 225);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(363, 69);
            this.tbNotes.TabIndex = 11;
            // 
            // tbOtherNames
            // 
            this.tbOtherNames.Location = new System.Drawing.Point(149, 80);
            this.tbOtherNames.Name = "tbOtherNames";
            this.tbOtherNames.Size = new System.Drawing.Size(173, 23);
            this.tbOtherNames.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(149, 51);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(173, 23);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(149, 22);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(173, 23);
            this.tbLastName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Commentaires";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autres prénoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nom";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 303);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(522, 55);
            this.pnlFooter.TabIndex = 14;
            // 
            // CreateEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un élève";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEleve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.TextBox tbOtherNames;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox pbEleve;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbSexe;
    }
}