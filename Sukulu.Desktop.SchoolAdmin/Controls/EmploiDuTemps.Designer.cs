
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class EmploiDuTemps
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlEmploiDuTemps = new System.Windows.Forms.Panel();
            this.pnlBodyEmploiDuTemps = new System.Windows.Forms.Panel();
            this.pnlHeaderSalleClasse = new System.Windows.Forms.Panel();
            this.cbSalleClasse = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlEmploiDuTemps.SuspendLayout();
            this.pnlHeaderSalleClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(875, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlEmploiDuTemps);
            this.pnlBody.Controls.Add(this.pnlFooter);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 37);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(875, 563);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlEmploiDuTemps
            // 
            this.pnlEmploiDuTemps.Controls.Add(this.pnlBodyEmploiDuTemps);
            this.pnlEmploiDuTemps.Controls.Add(this.pnlHeaderSalleClasse);
            this.pnlEmploiDuTemps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmploiDuTemps.Location = new System.Drawing.Point(0, 0);
            this.pnlEmploiDuTemps.Name = "pnlEmploiDuTemps";
            this.pnlEmploiDuTemps.Size = new System.Drawing.Size(875, 521);
            this.pnlEmploiDuTemps.TabIndex = 1;
            // 
            // pnlBodyEmploiDuTemps
            // 
            this.pnlBodyEmploiDuTemps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyEmploiDuTemps.Location = new System.Drawing.Point(0, 24);
            this.pnlBodyEmploiDuTemps.Name = "pnlBodyEmploiDuTemps";
            this.pnlBodyEmploiDuTemps.Size = new System.Drawing.Size(875, 497);
            this.pnlBodyEmploiDuTemps.TabIndex = 1;
            // 
            // pnlHeaderSalleClasse
            // 
            this.pnlHeaderSalleClasse.Controls.Add(this.cbSalleClasse);
            this.pnlHeaderSalleClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSalleClasse.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderSalleClasse.Name = "pnlHeaderSalleClasse";
            this.pnlHeaderSalleClasse.Size = new System.Drawing.Size(875, 24);
            this.pnlHeaderSalleClasse.TabIndex = 0;
            // 
            // cbSalleClasse
            // 
            this.cbSalleClasse.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSalleClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleClasse.FormattingEnabled = true;
            this.cbSalleClasse.Location = new System.Drawing.Point(0, 0);
            this.cbSalleClasse.Name = "cbSalleClasse";
            this.cbSalleClasse.Size = new System.Drawing.Size(248, 23);
            this.cbSalleClasse.TabIndex = 0;
            this.cbSalleClasse.SelectedIndexChanged += new System.EventHandler(this.cbSalleClasse_SelectedIndexChanged);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 521);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(875, 42);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(875, 37);
            this.pnlHeader.TabIndex = 0;
            // 
            // EmploiDuTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlMain);
            this.Name = "EmploiDuTemps";
            this.Size = new System.Drawing.Size(875, 600);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlEmploiDuTemps.ResumeLayout(false);
            this.pnlHeaderSalleClasse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlEmploiDuTemps;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBodyEmploiDuTemps;
        private System.Windows.Forms.Panel pnlHeaderSalleClasse;
        private System.Windows.Forms.ComboBox cbSalleClasse;
    }
}
