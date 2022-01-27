
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class SingleCoursPrevu
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
            this.llbMatiere = new System.Windows.Forms.LinkLabel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStartEndTime = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblEnseignant = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(123, 85);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.llbMatiere);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 30);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(123, 25);
            this.pnlBody.TabIndex = 1;
            // 
            // llbMatiere
            // 
            this.llbMatiere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbMatiere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbMatiere.Location = new System.Drawing.Point(0, 0);
            this.llbMatiere.Name = "llbMatiere";
            this.llbMatiere.Size = new System.Drawing.Size(123, 25);
            this.llbMatiere.TabIndex = 0;
            this.llbMatiere.TabStop = true;
            this.llbMatiere.Text = "[Matière]";
            this.llbMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblStartEndTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(123, 30);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblStartEndTime
            // 
            this.lblStartEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartEndTime.ForeColor = System.Drawing.Color.Green;
            this.lblStartEndTime.Location = new System.Drawing.Point(0, 0);
            this.lblStartEndTime.Name = "lblStartEndTime";
            this.lblStartEndTime.Size = new System.Drawing.Size(123, 30);
            this.lblStartEndTime.TabIndex = 0;
            this.lblStartEndTime.Text = "[Début - Fin]";
            this.lblStartEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblEnseignant);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 55);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(123, 30);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblEnseignant
            // 
            this.lblEnseignant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnseignant.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnseignant.ForeColor = System.Drawing.Color.Red;
            this.lblEnseignant.Location = new System.Drawing.Point(0, 0);
            this.lblEnseignant.Name = "lblEnseignant";
            this.lblEnseignant.Size = new System.Drawing.Size(123, 30);
            this.lblEnseignant.TabIndex = 0;
            this.lblEnseignant.Text = "[Professeur]";
            this.lblEnseignant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingleCoursPrevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SingleCoursPrevu";
            this.Size = new System.Drawing.Size(123, 85);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStartEndTime;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblEnseignant;
        private System.Windows.Forms.LinkLabel llbMatiere;
    }
}
