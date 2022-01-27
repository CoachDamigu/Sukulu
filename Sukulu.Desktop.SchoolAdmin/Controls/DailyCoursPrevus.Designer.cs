
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class DailyCoursPrevus
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
            this.flpCoursPrevuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.flpCoursPrevuItems);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(125, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // flpCoursPrevuItems
            // 
            this.flpCoursPrevuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCoursPrevuItems.Location = new System.Drawing.Point(0, 48);
            this.flpCoursPrevuItems.Margin = new System.Windows.Forms.Padding(0);
            this.flpCoursPrevuItems.Name = "flpCoursPrevuItems";
            this.flpCoursPrevuItems.Size = new System.Drawing.Size(125, 552);
            this.flpCoursPrevuItems.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDay);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(125, 48);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay.Location = new System.Drawing.Point(0, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(125, 48);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Jour - Date";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyCoursPrevus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "DailyCoursPrevus";
            this.Size = new System.Drawing.Size(125, 600);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flpCoursPrevuItems;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDay;
    }
}
