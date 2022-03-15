
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class SKLAdminConnect
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
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(273, 115);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblErrorMessage);
            this.pnlBody.Controls.Add(this.tbPassword);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.tbLogin);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(273, 85);
            this.pnlBody.TabIndex = 2;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 66);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(273, 19);
            this.lblErrorMessage.TabIndex = 4;
            this.lblErrorMessage.Text = "Messages d\'erreur";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(102, 41);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(153, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(102, 13);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(153, 23);
            this.tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom utilisateur";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnQuit);
            this.pnlFooter.Controls.Add(this.btnValidate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 85);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(273, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.Location = new System.Drawing.Point(211, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(60, 28);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnValidate.Location = new System.Drawing.Point(0, 0);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(58, 28);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // SKLAdminConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 115);
            this.Controls.Add(this.pnlMain);
            this.Name = "SKLAdminConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrateur SUKULU";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnValidate;
    }
}