
namespace Sukulu.Desktop.SchoolAdmin
{
    partial class SchoolAdminStart
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblEcoleAnneeScolaire = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.msSchoolAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSukulu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectDeconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEcole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnseignement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmploiDuTemps = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.msSchoolAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1040, 541);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 29);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1040, 484);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblEcoleAnneeScolaire);
            this.pnlFooter.Controls.Add(this.lblConnected);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 513);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1040, 28);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblEcoleAnneeScolaire
            // 
            this.lblEcoleAnneeScolaire.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEcoleAnneeScolaire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEcoleAnneeScolaire.ForeColor = System.Drawing.Color.Green;
            this.lblEcoleAnneeScolaire.Location = new System.Drawing.Point(660, 0);
            this.lblEcoleAnneeScolaire.Name = "lblEcoleAnneeScolaire";
            this.lblEcoleAnneeScolaire.Size = new System.Drawing.Size(380, 28);
            this.lblEcoleAnneeScolaire.TabIndex = 1;
            this.lblEcoleAnneeScolaire.Text = "Ecole [Anneé scolaire]";
            this.lblEcoleAnneeScolaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConnected
            // 
            this.lblConnected.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConnected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnected.ForeColor = System.Drawing.Color.Blue;
            this.lblConnected.Location = new System.Drawing.Point(0, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(228, 28);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.Text = "Vous n\'êtes pas connecté ...";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.msSchoolAdmin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1040, 29);
            this.pnlMenu.TabIndex = 0;
            // 
            // msSchoolAdmin
            // 
            this.msSchoolAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msSchoolAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSukulu});
            this.msSchoolAdmin.Location = new System.Drawing.Point(0, 0);
            this.msSchoolAdmin.Name = "msSchoolAdmin";
            this.msSchoolAdmin.Size = new System.Drawing.Size(1040, 29);
            this.msSchoolAdmin.TabIndex = 0;
            this.msSchoolAdmin.Text = "menuStrip1";
            // 
            // tsmiSukulu
            // 
            this.tsmiSukulu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectDeconnect,
            this.tsmiEcole,
            this.tsmiEnseignement,
            this.tsmiEmploiDuTemps,
            this.tsmiQuitter});
            this.tsmiSukulu.Name = "tsmiSukulu";
            this.tsmiSukulu.Size = new System.Drawing.Size(55, 25);
            this.tsmiSukulu.Text = "Sukulu";
            // 
            // tsmiConnectDeconnect
            // 
            this.tsmiConnectDeconnect.Name = "tsmiConnectDeconnect";
            this.tsmiConnectDeconnect.Size = new System.Drawing.Size(164, 22);
            this.tsmiConnectDeconnect.Text = "Se Connecter";
            this.tsmiConnectDeconnect.Click += new System.EventHandler(this.tsmiConnectDeconnect_Click);
            // 
            // tsmiEcole
            // 
            this.tsmiEcole.Name = "tsmiEcole";
            this.tsmiEcole.Size = new System.Drawing.Size(164, 22);
            this.tsmiEcole.Text = "Ecole";
            this.tsmiEcole.Click += new System.EventHandler(this.tsmiEcole_Click);
            // 
            // tsmiEnseignement
            // 
            this.tsmiEnseignement.Name = "tsmiEnseignement";
            this.tsmiEnseignement.Size = new System.Drawing.Size(164, 22);
            this.tsmiEnseignement.Text = "Enseignement";
            this.tsmiEnseignement.Click += new System.EventHandler(this.tsmiEnseignement_Click);
            // 
            // tsmiEmploiDuTemps
            // 
            this.tsmiEmploiDuTemps.Name = "tsmiEmploiDuTemps";
            this.tsmiEmploiDuTemps.Size = new System.Drawing.Size(164, 22);
            this.tsmiEmploiDuTemps.Text = "Emploi du temps";
            this.tsmiEmploiDuTemps.Click += new System.EventHandler(this.tsmiEmploiDuTemps_Click);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.Size = new System.Drawing.Size(164, 22);
            this.tsmiQuitter.Text = "Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            // 
            // SchoolAdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 541);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.msSchoolAdmin;
            this.Name = "SchoolAdminStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SUKULU (Gestion d\'établissements Scolaires)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.msSchoolAdmin.ResumeLayout(false);
            this.msSchoolAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.MenuStrip msSchoolAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSukulu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEcole;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnseignement;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmploiDuTemps;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectDeconnect;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblEcoleAnneeScolaire;
    }
}

