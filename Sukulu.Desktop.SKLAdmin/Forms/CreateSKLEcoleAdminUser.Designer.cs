
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class CreateSKLEcoleAdminUser
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbVerifyPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblEcole = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(64, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnQuit);
            this.pnlFooter.Controls.Add(this.btnCreate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 226);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(300, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.Location = new System.Drawing.Point(236, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(64, 30);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tbVerifyPassword
            // 
            this.tbVerifyPassword.Location = new System.Drawing.Point(128, 189);
            this.tbVerifyPassword.Name = "tbVerifyPassword";
            this.tbVerifyPassword.PasswordChar = '*';
            this.tbVerifyPassword.Size = new System.Drawing.Size(162, 23);
            this.tbVerifyPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vérifier mot de passe";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(128, 158);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(162, 23);
            this.tbPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(128, 130);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(162, 23);
            this.tbLogin.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(128, 96);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 23);
            this.tbEmail.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(128, 66);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(162, 23);
            this.tbFirstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(128, 36);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(162, 23);
            this.tbLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblEcole);
            this.pnlBody.Controls.Add(this.tbVerifyPassword);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.tbPassword);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.tbLogin);
            this.pnlBody.Controls.Add(this.tbEmail);
            this.pnlBody.Controls.Add(this.tbFirstName);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.tbLastName);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(300, 226);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(300, 256);
            this.pnlMain.TabIndex = 1;
            // 
            // lblEcole
            // 
            this.lblEcole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEcole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEcole.ForeColor = System.Drawing.Color.Blue;
            this.lblEcole.Location = new System.Drawing.Point(0, 0);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(300, 22);
            this.lblEcole.TabIndex = 12;
            this.lblEcole.Text = "Ecole";
            this.lblEcole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateSKLEcoleAdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 256);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateSKLEcoleAdminUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un adminstrateur d\'école";
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox tbVerifyPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblEcole;
    }
}