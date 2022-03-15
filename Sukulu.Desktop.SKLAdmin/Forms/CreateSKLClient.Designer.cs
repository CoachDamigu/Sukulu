
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class CreateSKLClient
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlBody.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tbNotes);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.tbName);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(339, 110);
            this.pnlBody.TabIndex = 1;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(61, 42);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(268, 62);
            this.tbNotes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(61, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 23);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(339, 140);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnQuit);
            this.pnlFooter.Controls.Add(this.btnCreate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 110);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(339, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.Location = new System.Drawing.Point(275, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(64, 30);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(64, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Créer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateSKLClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 140);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateSKLClient";
            this.Text = "CreateSKLClient";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCreate;
    }
}