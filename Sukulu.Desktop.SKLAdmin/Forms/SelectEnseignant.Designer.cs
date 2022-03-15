
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class SelectEnseignant
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvEnseignants = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCLose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignants)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelect.Location = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 36);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Sélectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvEnseignants);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 67);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(800, 347);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvEnseignants
            // 
            this.dgvEnseignants.AllowUserToAddRows = false;
            this.dgvEnseignants.AllowUserToDeleteRows = false;
            this.dgvEnseignants.AllowUserToResizeRows = false;
            this.dgvEnseignants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnseignants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnseignants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnseignants.Location = new System.Drawing.Point(0, 0);
            this.dgvEnseignants.MultiSelect = false;
            this.dgvEnseignants.Name = "dgvEnseignants";
            this.dgvEnseignants.RowHeadersVisible = false;
            this.dgvEnseignants.RowTemplate.Height = 25;
            this.dgvEnseignants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnseignants.Size = new System.Drawing.Size(800, 347);
            this.dgvEnseignants.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.tbEmail);
            this.pnlHeader.Controls.Add(this.tbFirstName);
            this.pnlHeader.Controls.Add(this.tbLastName);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 67);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(527, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(356, 30);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(154, 23);
            this.tbEmail.TabIndex = 5;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(182, 30);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(154, 23);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(14, 30);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(154, 23);
            this.tbLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCLose);
            this.pnlFooter.Controls.Add(this.btnSelect);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 414);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 36);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCLose
            // 
            this.btnCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCLose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCLose.Location = new System.Drawing.Point(727, 0);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(73, 36);
            this.btnCLose.TabIndex = 1;
            this.btnCLose.Text = "Quitter";
            this.btnCLose.UseVisualStyleBackColor = true;
            // 
            // SelectEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "SelectEnseignant";
            this.Text = "SelectEnseignant";
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignants)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvEnseignants;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCLose;
    }
}