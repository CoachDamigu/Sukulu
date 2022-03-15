
namespace Sukulu.Desktop.SKLAdmin
{
    partial class SKLAdminStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.msSKLAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSukulu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectDeconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSukuluSystemeScolaire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEcoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtilisateurs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblConnected = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.msSKLAdmin.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(946, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 30);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(946, 390);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.msSKLAdmin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(946, 30);
            this.pnlMenu.TabIndex = 1;
            // 
            // msSKLAdmin
            // 
            this.msSKLAdmin.BackColor = System.Drawing.Color.Transparent;
            this.msSKLAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msSKLAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msSKLAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSukulu});
            this.msSKLAdmin.Location = new System.Drawing.Point(0, 0);
            this.msSKLAdmin.Name = "msSKLAdmin";
            this.msSKLAdmin.Size = new System.Drawing.Size(946, 30);
            this.msSKLAdmin.TabIndex = 1;
            this.msSKLAdmin.Text = "menuStrip1";
            // 
            // tsmiSukulu
            // 
            this.tsmiSukulu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectDeconnect,
            this.tsmiSukuluSystemeScolaire,
            this.tsmiEcoles,
            this.tsmiUtilisateurs,
            this.tsmiQuit});
            this.tsmiSukulu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmiSukulu.ForeColor = System.Drawing.Color.Blue;
            this.tsmiSukulu.Name = "tsmiSukulu";
            this.tsmiSukulu.Size = new System.Drawing.Size(65, 26);
            this.tsmiSukulu.Text = "Sukulu";
            // 
            // tsmiConnectDeconnect
            // 
            this.tsmiConnectDeconnect.Name = "tsmiConnectDeconnect";
            this.tsmiConnectDeconnect.Size = new System.Drawing.Size(198, 24);
            this.tsmiConnectDeconnect.Text = "Se connecter";
            this.tsmiConnectDeconnect.Click += new System.EventHandler(this.tsmiConnectDeconnect_Click);
            // 
            // tsmiSukuluSystemeScolaire
            // 
            this.tsmiSukuluSystemeScolaire.Name = "tsmiSukuluSystemeScolaire";
            this.tsmiSukuluSystemeScolaire.Size = new System.Drawing.Size(198, 24);
            this.tsmiSukuluSystemeScolaire.Text = "Systeme Scolaires";
            this.tsmiSukuluSystemeScolaire.Click += new System.EventHandler(this.tsmiSukuluSystemeScolaire_Click);
            // 
            // tsmiEcoles
            // 
            this.tsmiEcoles.Name = "tsmiEcoles";
            this.tsmiEcoles.Size = new System.Drawing.Size(198, 24);
            this.tsmiEcoles.Text = "Ecoles";
            // 
            // tsmiUtilisateurs
            // 
            this.tsmiUtilisateurs.Name = "tsmiUtilisateurs";
            this.tsmiUtilisateurs.Size = new System.Drawing.Size(198, 24);
            this.tsmiUtilisateurs.Text = "Utilisateurs";
            this.tsmiUtilisateurs.Click += new System.EventHandler(this.tsmiUtilisateurs_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(198, 24);
            this.tsmiQuit.Text = "Quitter";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblConnected);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 420);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(946, 30);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblConnected
            // 
            this.lblConnected.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConnected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnected.ForeColor = System.Drawing.Color.Blue;
            this.lblConnected.Location = new System.Drawing.Point(0, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(440, 30);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "Vous n\'êtes pas connecté(e)";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SKLAdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SKLAdminStart";
            this.ShowIcon = false;
            this.Text = "Sukulu (Gestion d\'établissements scolaires)";
            this.pnlMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.msSKLAdmin.ResumeLayout(false);
            this.msSKLAdmin.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip msSKLAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSukulu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSukuluSystemeScolaire;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEcoles;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtilisateurs;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectDeconnect;
        private System.Windows.Forms.Label lblConnected;
    }
}

