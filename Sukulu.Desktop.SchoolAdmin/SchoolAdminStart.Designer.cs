
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.msSchoolAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSukulu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEcole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 29);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(800, 366);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.msSchoolAdmin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 29);
            this.pnlMenu.TabIndex = 0;
            // 
            // msSchoolAdmin
            // 
            this.msSchoolAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msSchoolAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSukulu});
            this.msSchoolAdmin.Location = new System.Drawing.Point(0, 0);
            this.msSchoolAdmin.Name = "msSchoolAdmin";
            this.msSchoolAdmin.Size = new System.Drawing.Size(800, 29);
            this.msSchoolAdmin.TabIndex = 0;
            this.msSchoolAdmin.Text = "menuStrip1";
            // 
            // tsmiSukulu
            // 
            this.tsmiSukulu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEcole,
            this.tsmiQuitter});
            this.tsmiSukulu.Name = "tsmiSukulu";
            this.tsmiSukulu.Size = new System.Drawing.Size(55, 25);
            this.tsmiSukulu.Text = "Sukulu";
            // 
            // tsmiEcole
            // 
            this.tsmiEcole.Name = "tsmiEcole";
            this.tsmiEcole.Size = new System.Drawing.Size(180, 22);
            this.tsmiEcole.Text = "Ecole";
            this.tsmiEcole.Click += new System.EventHandler(this.tsmiEcole_Click);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.Size = new System.Drawing.Size(180, 22);
            this.tsmiQuitter.Text = "Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 395);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 55);
            this.pnlFooter.TabIndex = 2;
            // 
            // SchoolAdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.msSchoolAdmin;
            this.Name = "SchoolAdminStart";
            this.Text = "SUKULU (Gestion d\'établissements Scolaires)";
            this.pnlMain.ResumeLayout(false);
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
    }
}

