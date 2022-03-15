
namespace Sukulu.Desktop.SKLAdmin.Forms
{
    partial class SelectTypeUtilisateurToCreate
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
            this.cbTypeUtilisateur = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTypeUtilisateur
            // 
            this.cbTypeUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTypeUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeUtilisateur.FormattingEnabled = true;
            this.cbTypeUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.cbTypeUtilisateur.Name = "cbTypeUtilisateur";
            this.cbTypeUtilisateur.Size = new System.Drawing.Size(242, 23);
            this.cbTypeUtilisateur.TabIndex = 0;
            this.cbTypeUtilisateur.SelectedIndexChanged += new System.EventHandler(this.cbTypeUtilisateur_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(57, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(123, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Sélectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectTypeUtilisateurToCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 61);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbTypeUtilisateur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTypeUtilisateurToCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Type utilisateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypeUtilisateur;
        private System.Windows.Forms.Button btnSelect;
    }
}