
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class WeeklyCoursPrevu
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
            this.flpDailyItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlWeekLabel = new System.Windows.Forms.Panel();
            this.lblWeekDisplay = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlWeekLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.flpDailyItems);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1061, 598);
            this.pnlMain.TabIndex = 0;
            // 
            // flpDailyItems
            // 
            this.flpDailyItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDailyItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDailyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDailyItems.Location = new System.Drawing.Point(0, 30);
            this.flpDailyItems.Margin = new System.Windows.Forms.Padding(0);
            this.flpDailyItems.Name = "flpDailyItems";
            this.flpDailyItems.Size = new System.Drawing.Size(1061, 568);
            this.flpDailyItems.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.pnlWeekLabel);
            this.pnlHeader.Controls.Add(this.btnRight);
            this.pnlHeader.Controls.Add(this.btnLeft);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1061, 30);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlWeekLabel
            // 
            this.pnlWeekLabel.Controls.Add(this.lblWeekDisplay);
            this.pnlWeekLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWeekLabel.Location = new System.Drawing.Point(30, 0);
            this.pnlWeekLabel.Name = "pnlWeekLabel";
            this.pnlWeekLabel.Size = new System.Drawing.Size(999, 28);
            this.pnlWeekLabel.TabIndex = 2;
            // 
            // lblWeekDisplay
            // 
            this.lblWeekDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeekDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeekDisplay.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblWeekDisplay.Name = "lblWeekDisplay";
            this.lblWeekDisplay.Size = new System.Drawing.Size(999, 28);
            this.lblWeekDisplay.TabIndex = 0;
            this.lblWeekDisplay.Text = "[Semaine du ---- Au -----]";
            this.lblWeekDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::Sukulu.Desktop.SchoolAdmin.Properties.Resources.sort_right_48px;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.Location = new System.Drawing.Point(1029, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 28);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::Sukulu.Desktop.SchoolAdmin.Properties.Resources.sort_left_48px;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 28);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // WeeklyCoursPrevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WeeklyCoursPrevu";
            this.Size = new System.Drawing.Size(1061, 598);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlWeekLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flpDailyItems;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlWeekLabel;
        private System.Windows.Forms.Label lblWeekDisplay;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}
