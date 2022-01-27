
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class EnseignementActions
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
            this.tcEnseignement = new System.Windows.Forms.TabControl();
            this.tpMatieres = new System.Windows.Forms.TabPage();
            this.dgvMatieres = new System.Windows.Forms.DataGridView();
            this.tpClasseMatieres = new System.Windows.Forms.TabPage();
            this.pnlMatiereSalleClasse = new System.Windows.Forms.Panel();
            this.dgvMatiereSalleClasse = new System.Windows.Forms.DataGridView();
            this.pnlHeaderSalleClasse = new System.Windows.Forms.Panel();
            this.cbSalleClasse = new System.Windows.Forms.ComboBox();
            this.tpProfesseurs = new System.Windows.Forms.TabPage();
            this.pnlEleveData = new System.Windows.Forms.Panel();
            this.dgvEnseignants = new System.Windows.Forms.DataGridView();
            this.tbProfesseurPortfolio = new System.Windows.Forms.TabPage();
            this.pnlPortfolioEnseignant = new System.Windows.Forms.Panel();
            this.dgvPortfolioEnseignant = new System.Windows.Forms.DataGridView();
            this.pnlHeaderPortfolioEnseignant = new System.Windows.Forms.Panel();
            this.cbEnseignants = new System.Windows.Forms.ComboBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tcEnseignement.SuspendLayout();
            this.tpMatieres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieres)).BeginInit();
            this.tpClasseMatieres.SuspendLayout();
            this.pnlMatiereSalleClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiereSalleClasse)).BeginInit();
            this.pnlHeaderSalleClasse.SuspendLayout();
            this.tpProfesseurs.SuspendLayout();
            this.pnlEleveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignants)).BeginInit();
            this.tbProfesseurPortfolio.SuspendLayout();
            this.pnlPortfolioEnseignant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolioEnseignant)).BeginInit();
            this.pnlHeaderPortfolioEnseignant.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(928, 390);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tcEnseignement);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(928, 312);
            this.pnlBody.TabIndex = 2;
            // 
            // tcEnseignement
            // 
            this.tcEnseignement.Controls.Add(this.tpMatieres);
            this.tcEnseignement.Controls.Add(this.tpClasseMatieres);
            this.tcEnseignement.Controls.Add(this.tpProfesseurs);
            this.tcEnseignement.Controls.Add(this.tbProfesseurPortfolio);
            this.tcEnseignement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEnseignement.Location = new System.Drawing.Point(0, 0);
            this.tcEnseignement.Name = "tcEnseignement";
            this.tcEnseignement.SelectedIndex = 0;
            this.tcEnseignement.Size = new System.Drawing.Size(928, 312);
            this.tcEnseignement.TabIndex = 0;
            // 
            // tpMatieres
            // 
            this.tpMatieres.Controls.Add(this.dgvMatieres);
            this.tpMatieres.Location = new System.Drawing.Point(4, 24);
            this.tpMatieres.Name = "tpMatieres";
            this.tpMatieres.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatieres.Size = new System.Drawing.Size(920, 284);
            this.tpMatieres.TabIndex = 0;
            this.tpMatieres.Text = "Matières";
            this.tpMatieres.UseVisualStyleBackColor = true;
            // 
            // dgvMatieres
            // 
            this.dgvMatieres.AllowUserToAddRows = false;
            this.dgvMatieres.AllowUserToDeleteRows = false;
            this.dgvMatieres.AllowUserToResizeRows = false;
            this.dgvMatieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatieres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatieres.Location = new System.Drawing.Point(3, 3);
            this.dgvMatieres.MultiSelect = false;
            this.dgvMatieres.Name = "dgvMatieres";
            this.dgvMatieres.RowHeadersVisible = false;
            this.dgvMatieres.RowTemplate.Height = 25;
            this.dgvMatieres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatieres.Size = new System.Drawing.Size(914, 278);
            this.dgvMatieres.TabIndex = 0;
            // 
            // tpClasseMatieres
            // 
            this.tpClasseMatieres.Controls.Add(this.pnlMatiereSalleClasse);
            this.tpClasseMatieres.Controls.Add(this.pnlHeaderSalleClasse);
            this.tpClasseMatieres.Location = new System.Drawing.Point(4, 24);
            this.tpClasseMatieres.Name = "tpClasseMatieres";
            this.tpClasseMatieres.Size = new System.Drawing.Size(920, 284);
            this.tpClasseMatieres.TabIndex = 2;
            this.tpClasseMatieres.Text = "Matières par Salle de Classe";
            this.tpClasseMatieres.UseVisualStyleBackColor = true;
            // 
            // pnlMatiereSalleClasse
            // 
            this.pnlMatiereSalleClasse.Controls.Add(this.dgvMatiereSalleClasse);
            this.pnlMatiereSalleClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatiereSalleClasse.Location = new System.Drawing.Point(0, 22);
            this.pnlMatiereSalleClasse.Name = "pnlMatiereSalleClasse";
            this.pnlMatiereSalleClasse.Size = new System.Drawing.Size(920, 262);
            this.pnlMatiereSalleClasse.TabIndex = 1;
            // 
            // dgvMatiereSalleClasse
            // 
            this.dgvMatiereSalleClasse.AllowUserToAddRows = false;
            this.dgvMatiereSalleClasse.AllowUserToDeleteRows = false;
            this.dgvMatiereSalleClasse.AllowUserToResizeRows = false;
            this.dgvMatiereSalleClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatiereSalleClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatiereSalleClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatiereSalleClasse.Location = new System.Drawing.Point(0, 0);
            this.dgvMatiereSalleClasse.MultiSelect = false;
            this.dgvMatiereSalleClasse.Name = "dgvMatiereSalleClasse";
            this.dgvMatiereSalleClasse.RowHeadersVisible = false;
            this.dgvMatiereSalleClasse.RowTemplate.Height = 25;
            this.dgvMatiereSalleClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatiereSalleClasse.Size = new System.Drawing.Size(920, 262);
            this.dgvMatiereSalleClasse.TabIndex = 0;
            // 
            // pnlHeaderSalleClasse
            // 
            this.pnlHeaderSalleClasse.Controls.Add(this.cbSalleClasse);
            this.pnlHeaderSalleClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSalleClasse.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderSalleClasse.Name = "pnlHeaderSalleClasse";
            this.pnlHeaderSalleClasse.Size = new System.Drawing.Size(920, 22);
            this.pnlHeaderSalleClasse.TabIndex = 0;
            // 
            // cbSalleClasse
            // 
            this.cbSalleClasse.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSalleClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleClasse.FormattingEnabled = true;
            this.cbSalleClasse.Location = new System.Drawing.Point(0, 0);
            this.cbSalleClasse.Name = "cbSalleClasse";
            this.cbSalleClasse.Size = new System.Drawing.Size(241, 23);
            this.cbSalleClasse.TabIndex = 0;
            this.cbSalleClasse.SelectedIndexChanged += new System.EventHandler(this.cbSalleClasse_SelectedIndexChanged);
            // 
            // tpProfesseurs
            // 
            this.tpProfesseurs.Controls.Add(this.pnlEleveData);
            this.tpProfesseurs.Location = new System.Drawing.Point(4, 24);
            this.tpProfesseurs.Name = "tpProfesseurs";
            this.tpProfesseurs.Size = new System.Drawing.Size(920, 284);
            this.tpProfesseurs.TabIndex = 1;
            this.tpProfesseurs.Text = "Professeurs";
            this.tpProfesseurs.UseVisualStyleBackColor = true;
            // 
            // pnlEleveData
            // 
            this.pnlEleveData.Controls.Add(this.dgvEnseignants);
            this.pnlEleveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEleveData.Location = new System.Drawing.Point(0, 0);
            this.pnlEleveData.Name = "pnlEleveData";
            this.pnlEleveData.Size = new System.Drawing.Size(920, 284);
            this.pnlEleveData.TabIndex = 1;
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
            this.dgvEnseignants.Size = new System.Drawing.Size(920, 284);
            this.dgvEnseignants.TabIndex = 0;
            // 
            // tbProfesseurPortfolio
            // 
            this.tbProfesseurPortfolio.Controls.Add(this.pnlPortfolioEnseignant);
            this.tbProfesseurPortfolio.Controls.Add(this.pnlHeaderPortfolioEnseignant);
            this.tbProfesseurPortfolio.Location = new System.Drawing.Point(4, 24);
            this.tbProfesseurPortfolio.Name = "tbProfesseurPortfolio";
            this.tbProfesseurPortfolio.Size = new System.Drawing.Size(920, 284);
            this.tbProfesseurPortfolio.TabIndex = 3;
            this.tbProfesseurPortfolio.Text = "Portfolio des  Professeurs";
            this.tbProfesseurPortfolio.UseVisualStyleBackColor = true;
            // 
            // pnlPortfolioEnseignant
            // 
            this.pnlPortfolioEnseignant.Controls.Add(this.dgvPortfolioEnseignant);
            this.pnlPortfolioEnseignant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPortfolioEnseignant.Location = new System.Drawing.Point(0, 24);
            this.pnlPortfolioEnseignant.Name = "pnlPortfolioEnseignant";
            this.pnlPortfolioEnseignant.Size = new System.Drawing.Size(920, 260);
            this.pnlPortfolioEnseignant.TabIndex = 1;
            // 
            // dgvPortfolioEnseignant
            // 
            this.dgvPortfolioEnseignant.AllowUserToAddRows = false;
            this.dgvPortfolioEnseignant.AllowUserToDeleteRows = false;
            this.dgvPortfolioEnseignant.AllowUserToResizeRows = false;
            this.dgvPortfolioEnseignant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPortfolioEnseignant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortfolioEnseignant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPortfolioEnseignant.Location = new System.Drawing.Point(0, 0);
            this.dgvPortfolioEnseignant.MultiSelect = false;
            this.dgvPortfolioEnseignant.Name = "dgvPortfolioEnseignant";
            this.dgvPortfolioEnseignant.RowHeadersVisible = false;
            this.dgvPortfolioEnseignant.RowTemplate.Height = 25;
            this.dgvPortfolioEnseignant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortfolioEnseignant.Size = new System.Drawing.Size(920, 260);
            this.dgvPortfolioEnseignant.TabIndex = 0;
            // 
            // pnlHeaderPortfolioEnseignant
            // 
            this.pnlHeaderPortfolioEnseignant.Controls.Add(this.cbEnseignants);
            this.pnlHeaderPortfolioEnseignant.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPortfolioEnseignant.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPortfolioEnseignant.Name = "pnlHeaderPortfolioEnseignant";
            this.pnlHeaderPortfolioEnseignant.Size = new System.Drawing.Size(920, 24);
            this.pnlHeaderPortfolioEnseignant.TabIndex = 0;
            // 
            // cbEnseignants
            // 
            this.cbEnseignants.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbEnseignants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnseignants.FormattingEnabled = true;
            this.cbEnseignants.Location = new System.Drawing.Point(0, 0);
            this.cbEnseignants.Name = "cbEnseignants";
            this.cbEnseignants.Size = new System.Drawing.Size(247, 23);
            this.cbEnseignants.TabIndex = 0;
            this.cbEnseignants.SelectedIndexChanged += new System.EventHandler(this.cbEnseignants_SelectedIndexChanged);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(928, 36);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 348);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(928, 42);
            this.pnlFooter.TabIndex = 3;
            // 
            // EnseignementActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "EnseignementActions";
            this.Size = new System.Drawing.Size(928, 390);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tcEnseignement.ResumeLayout(false);
            this.tpMatieres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieres)).EndInit();
            this.tpClasseMatieres.ResumeLayout(false);
            this.pnlMatiereSalleClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiereSalleClasse)).EndInit();
            this.pnlHeaderSalleClasse.ResumeLayout(false);
            this.tpProfesseurs.ResumeLayout(false);
            this.pnlEleveData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnseignants)).EndInit();
            this.tbProfesseurPortfolio.ResumeLayout(false);
            this.pnlPortfolioEnseignant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolioEnseignant)).EndInit();
            this.pnlHeaderPortfolioEnseignant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabControl tcEnseignement;
        private System.Windows.Forms.TabPage tpMatieres;
        private System.Windows.Forms.DataGridView dgvMatieres;
        private System.Windows.Forms.TabPage tpClasseMatieres;
        private System.Windows.Forms.TabPage tpProfesseurs;
        private System.Windows.Forms.Panel pnlEleveData;
        private System.Windows.Forms.DataGridView dgvEnseignants;
        private System.Windows.Forms.TabPage tbProfesseurPortfolio;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMatiereSalleClasse;
        private System.Windows.Forms.DataGridView dgvMatiereSalleClasse;
        private System.Windows.Forms.Panel pnlHeaderSalleClasse;
        private System.Windows.Forms.ComboBox cbSalleClasse;
        private System.Windows.Forms.Panel pnlPortfolioEnseignant;
        private System.Windows.Forms.Panel pnlHeaderPortfolioEnseignant;
        private System.Windows.Forms.DataGridView dgvPortfolioEnseignant;
        private System.Windows.Forms.ComboBox cbEnseignants;
    }
}
