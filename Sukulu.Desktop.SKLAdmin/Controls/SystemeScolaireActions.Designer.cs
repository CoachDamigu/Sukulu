
namespace Sukulu.Desktop.SKLAdmin.Controls
{
    partial class SystemeScolaireActions
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
            this.tcSystemeScolaire = new System.Windows.Forms.TabControl();
            this.tpSystemeScolaire = new System.Windows.Forms.TabPage();
            this.dgvSystemeScolaires = new System.Windows.Forms.DataGridView();
            this.tpEnseignement = new System.Windows.Forms.TabPage();
            this.pnlEnseignement = new System.Windows.Forms.Panel();
            this.dgvEnseignements = new System.Windows.Forms.DataGridView();
            this.tpNiveau = new System.Windows.Forms.TabPage();
            this.pnlNiveaux = new System.Windows.Forms.Panel();
            this.dgvNiveaux = new System.Windows.Forms.DataGridView();
            this.tpSerie = new System.Windows.Forms.TabPage();
            this.dgvSeries = new System.Windows.Forms.DataGridView();
            this.tpClasse = new System.Windows.Forms.TabPage();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.tcSystemeScolaire.SuspendLayout();
            this.tpSystemeScolaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemeScolaires)).BeginInit();
            this.tpEnseignement.SuspendLayout();
            this.pnlEnseignement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignements)).BeginInit();
            this.tpNiveau.SuspendLayout();
            this.pnlNiveaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveaux)).BeginInit();
            this.tpSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).BeginInit();
            this.tpClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1128, 36);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tcSystemeScolaire);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1128, 378);
            this.pnlBody.TabIndex = 1;
            // 
            // tcSystemeScolaire
            // 
            this.tcSystemeScolaire.Controls.Add(this.tpSystemeScolaire);
            this.tcSystemeScolaire.Controls.Add(this.tpEnseignement);
            this.tcSystemeScolaire.Controls.Add(this.tpNiveau);
            this.tcSystemeScolaire.Controls.Add(this.tpSerie);
            this.tcSystemeScolaire.Controls.Add(this.tpClasse);
            this.tcSystemeScolaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSystemeScolaire.Location = new System.Drawing.Point(0, 0);
            this.tcSystemeScolaire.Name = "tcSystemeScolaire";
            this.tcSystemeScolaire.SelectedIndex = 0;
            this.tcSystemeScolaire.Size = new System.Drawing.Size(1128, 378);
            this.tcSystemeScolaire.TabIndex = 0;
            this.tcSystemeScolaire.SelectedIndexChanged += new System.EventHandler(this.tcSystemeScolaire_SelectedIndexChanged);
            // 
            // tpSystemeScolaire
            // 
            this.tpSystemeScolaire.Controls.Add(this.dgvSystemeScolaires);
            this.tpSystemeScolaire.Location = new System.Drawing.Point(4, 24);
            this.tpSystemeScolaire.Name = "tpSystemeScolaire";
            this.tpSystemeScolaire.Padding = new System.Windows.Forms.Padding(3);
            this.tpSystemeScolaire.Size = new System.Drawing.Size(1120, 350);
            this.tpSystemeScolaire.TabIndex = 0;
            this.tpSystemeScolaire.Text = "Système scolaires";
            this.tpSystemeScolaire.UseVisualStyleBackColor = true;
            // 
            // dgvSystemeScolaires
            // 
            this.dgvSystemeScolaires.AllowUserToAddRows = false;
            this.dgvSystemeScolaires.AllowUserToDeleteRows = false;
            this.dgvSystemeScolaires.AllowUserToResizeRows = false;
            this.dgvSystemeScolaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystemeScolaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemeScolaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSystemeScolaires.Location = new System.Drawing.Point(3, 3);
            this.dgvSystemeScolaires.MultiSelect = false;
            this.dgvSystemeScolaires.Name = "dgvSystemeScolaires";
            this.dgvSystemeScolaires.RowHeadersVisible = false;
            this.dgvSystemeScolaires.RowTemplate.Height = 25;
            this.dgvSystemeScolaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemeScolaires.Size = new System.Drawing.Size(1114, 344);
            this.dgvSystemeScolaires.TabIndex = 0;
            // 
            // tpEnseignement
            // 
            this.tpEnseignement.Controls.Add(this.pnlEnseignement);
            this.tpEnseignement.Location = new System.Drawing.Point(4, 24);
            this.tpEnseignement.Name = "tpEnseignement";
            this.tpEnseignement.Size = new System.Drawing.Size(1120, 350);
            this.tpEnseignement.TabIndex = 4;
            this.tpEnseignement.Text = "Enseignements";
            this.tpEnseignement.UseVisualStyleBackColor = true;
            // 
            // pnlEnseignement
            // 
            this.pnlEnseignement.Controls.Add(this.dgvEnseignements);
            this.pnlEnseignement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnseignement.Location = new System.Drawing.Point(0, 0);
            this.pnlEnseignement.Name = "pnlEnseignement";
            this.pnlEnseignement.Size = new System.Drawing.Size(1120, 350);
            this.pnlEnseignement.TabIndex = 1;
            // 
            // dgvEnseignements
            // 
            this.dgvEnseignements.AllowUserToAddRows = false;
            this.dgvEnseignements.AllowUserToDeleteRows = false;
            this.dgvEnseignements.AllowUserToResizeRows = false;
            this.dgvEnseignements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnseignements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnseignements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnseignements.Location = new System.Drawing.Point(0, 0);
            this.dgvEnseignements.MultiSelect = false;
            this.dgvEnseignements.Name = "dgvEnseignements";
            this.dgvEnseignements.RowHeadersVisible = false;
            this.dgvEnseignements.RowTemplate.Height = 25;
            this.dgvEnseignements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnseignements.Size = new System.Drawing.Size(1120, 350);
            this.dgvEnseignements.TabIndex = 0;
            // 
            // tpNiveau
            // 
            this.tpNiveau.Controls.Add(this.pnlNiveaux);
            this.tpNiveau.Location = new System.Drawing.Point(4, 24);
            this.tpNiveau.Name = "tpNiveau";
            this.tpNiveau.Padding = new System.Windows.Forms.Padding(3);
            this.tpNiveau.Size = new System.Drawing.Size(1120, 350);
            this.tpNiveau.TabIndex = 1;
            this.tpNiveau.Text = "Niveaux";
            this.tpNiveau.UseVisualStyleBackColor = true;
            // 
            // pnlNiveaux
            // 
            this.pnlNiveaux.Controls.Add(this.dgvNiveaux);
            this.pnlNiveaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNiveaux.Location = new System.Drawing.Point(3, 3);
            this.pnlNiveaux.Name = "pnlNiveaux";
            this.pnlNiveaux.Size = new System.Drawing.Size(1114, 344);
            this.pnlNiveaux.TabIndex = 1;
            // 
            // dgvNiveaux
            // 
            this.dgvNiveaux.AllowUserToAddRows = false;
            this.dgvNiveaux.AllowUserToDeleteRows = false;
            this.dgvNiveaux.AllowUserToResizeRows = false;
            this.dgvNiveaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNiveaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveaux.ColumnHeadersVisible = false;
            this.dgvNiveaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNiveaux.Location = new System.Drawing.Point(0, 0);
            this.dgvNiveaux.MultiSelect = false;
            this.dgvNiveaux.Name = "dgvNiveaux";
            this.dgvNiveaux.RowTemplate.Height = 25;
            this.dgvNiveaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiveaux.Size = new System.Drawing.Size(1114, 344);
            this.dgvNiveaux.TabIndex = 0;
            // 
            // tpSerie
            // 
            this.tpSerie.Controls.Add(this.dgvSeries);
            this.tpSerie.Location = new System.Drawing.Point(4, 24);
            this.tpSerie.Name = "tpSerie";
            this.tpSerie.Size = new System.Drawing.Size(1120, 350);
            this.tpSerie.TabIndex = 2;
            this.tpSerie.Text = "Séries";
            this.tpSerie.UseVisualStyleBackColor = true;
            // 
            // dgvSeries
            // 
            this.dgvSeries.AllowUserToAddRows = false;
            this.dgvSeries.AllowUserToDeleteRows = false;
            this.dgvSeries.AllowUserToResizeRows = false;
            this.dgvSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeries.Location = new System.Drawing.Point(0, 0);
            this.dgvSeries.MultiSelect = false;
            this.dgvSeries.Name = "dgvSeries";
            this.dgvSeries.RowHeadersVisible = false;
            this.dgvSeries.RowTemplate.Height = 25;
            this.dgvSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeries.Size = new System.Drawing.Size(1120, 350);
            this.dgvSeries.TabIndex = 0;
            // 
            // tpClasse
            // 
            this.tpClasse.Controls.Add(this.dgvClasses);
            this.tpClasse.Location = new System.Drawing.Point(4, 24);
            this.tpClasse.Name = "tpClasse";
            this.tpClasse.Size = new System.Drawing.Size(1120, 350);
            this.tpClasse.TabIndex = 3;
            this.tpClasse.Text = "Classes";
            this.tpClasse.UseVisualStyleBackColor = true;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AllowUserToResizeRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasses.Location = new System.Drawing.Point(0, 0);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowTemplate.Height = 25;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(1120, 350);
            this.dgvClasses.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 414);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1128, 52);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1128, 466);
            this.pnlMain.TabIndex = 3;
            // 
            // SystemeScolaireActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "SystemeScolaireActions";
            this.Size = new System.Drawing.Size(1128, 466);
            this.pnlBody.ResumeLayout(false);
            this.tcSystemeScolaire.ResumeLayout(false);
            this.tpSystemeScolaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemeScolaires)).EndInit();
            this.tpEnseignement.ResumeLayout(false);
            this.pnlEnseignement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignements)).EndInit();
            this.tpNiveau.ResumeLayout(false);
            this.pnlNiveaux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveaux)).EndInit();
            this.tpSerie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeries)).EndInit();
            this.tpClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tcSystemeScolaire;
        private System.Windows.Forms.TabPage tpSystemeScolaire;
        private System.Windows.Forms.DataGridView dgvSystemeScolaires;
        private System.Windows.Forms.TabPage tpNiveau;
        private System.Windows.Forms.DataGridView dgvNiveaux;
        private System.Windows.Forms.TabPage tpSerie;
        private System.Windows.Forms.DataGridView dgvSeries;
        private System.Windows.Forms.TabPage tpClasse;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TabPage tpEnseignement;
        private System.Windows.Forms.Panel pnlEnseignement;
        private System.Windows.Forms.DataGridView dgvEnseignements;
        private System.Windows.Forms.Panel pnlNiveaux;
    }
}
