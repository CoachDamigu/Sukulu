
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class SaveAddQuit
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
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveQuit = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.flpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.flpControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(170, 53);
            this.pnlMain.TabIndex = 1;
            // 
            // flpControls
            // 
            this.flpControls.Controls.Add(this.btnSaveQuit);
            this.flpControls.Controls.Add(this.btnSaveAdd);
            this.flpControls.Controls.Add(this.btnQuit);
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpControls.Location = new System.Drawing.Point(0, 0);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(163, 53);
            this.flpControls.TabIndex = 0;
            // 
            // btnSaveQuit
            // 
            this.btnSaveQuit.Image = global::Sukulu.Desktop.SchoolAdmin.Properties.Resources.save_close_48px;
            this.btnSaveQuit.Location = new System.Drawing.Point(3, 3);
            this.btnSaveQuit.Name = "btnSaveQuit";
            this.btnSaveQuit.Size = new System.Drawing.Size(48, 48);
            this.btnSaveQuit.TabIndex = 2;
            this.btnSaveQuit.UseVisualStyleBackColor = true;
            this.btnSaveQuit.Click += new System.EventHandler(this.btnSaveQuit_Click);
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Image = global::Sukulu.Desktop.SchoolAdmin.Properties.Resources.save_Add_48px;
            this.btnSaveAdd.Location = new System.Drawing.Point(57, 3);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(48, 48);
            this.btnSaveAdd.TabIndex = 1;
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::Sukulu.Desktop.SchoolAdmin.Properties.Resources.Logout_48px;
            this.btnQuit.Location = new System.Drawing.Point(111, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(48, 48);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // SaveAddQuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "SaveAddQuit";
            this.Size = new System.Drawing.Size(170, 53);
            this.pnlMain.ResumeLayout(false);
            this.flpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        public System.Windows.Forms.Button btnSaveQuit;
        public System.Windows.Forms.Button btnSaveAdd;
        public System.Windows.Forms.Button btnQuit;
    }
}
