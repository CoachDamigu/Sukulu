
namespace Sukulu.Desktop.SKLAdmin.Controls
{
    partial class ClientUtilisateurResourcesActions
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlClientUserReources = new System.Windows.Forms.Panel();
            this.tvClientUserResources = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.pnlClientUserReources.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 36);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlDetails);
            this.pnlBody.Controls.Add(this.pnlClientUserReources);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(982, 440);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(416, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(566, 440);
            this.pnlDetails.TabIndex = 1;
            // 
            // pnlClientUserReources
            // 
            this.pnlClientUserReources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientUserReources.Controls.Add(this.tvClientUserResources);
            this.pnlClientUserReources.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClientUserReources.Location = new System.Drawing.Point(0, 0);
            this.pnlClientUserReources.Name = "pnlClientUserReources";
            this.pnlClientUserReources.Size = new System.Drawing.Size(416, 440);
            this.pnlClientUserReources.TabIndex = 0;
            // 
            // tvClientUserResources
            // 
            this.tvClientUserResources.BackColor = System.Drawing.SystemColors.Control;
            this.tvClientUserResources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvClientUserResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvClientUserResources.Location = new System.Drawing.Point(0, 0);
            this.tvClientUserResources.Name = "tvClientUserResources";
            this.tvClientUserResources.Size = new System.Drawing.Size(414, 438);
            this.tvClientUserResources.TabIndex = 0;
            this.tvClientUserResources.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvClientUserResources_AfterSelect);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(982, 518);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 476);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(982, 42);
            this.pnlFooter.TabIndex = 2;
            // 
            // ClientUtilisateurResourcesActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ClientUtilisateurResourcesActions";
            this.Size = new System.Drawing.Size(982, 518);
            this.pnlBody.ResumeLayout(false);
            this.pnlClientUserReources.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlClientUserReources;
        private System.Windows.Forms.TreeView tvClientUserResources;
    }
}
