
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class EcoleActions
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
            this.tcEcole = new System.Windows.Forms.TabControl();
            this.tpClasses = new System.Windows.Forms.TabPage();
            this.dgvSalleClasses = new System.Windows.Forms.DataGridView();
            this.tpEleves = new System.Windows.Forms.TabPage();
            this.pnlEleveData = new System.Windows.Forms.Panel();
            this.dgvEleves = new System.Windows.Forms.DataGridView();
            this.pnlHeaderEleve = new System.Windows.Forms.Panel();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.tpInscriptions = new System.Windows.Forms.TabPage();
            this.dgvInscriptions = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tcEcole.SuspendLayout();
            this.tpClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalleClasses)).BeginInit();
            this.tpEleves.SuspendLayout();
            this.pnlEleveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).BeginInit();
            this.pnlHeaderEleve.SuspendLayout();
            this.tpInscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(772, 501);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tcEcole);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(772, 423);
            this.pnlBody.TabIndex = 2;
            // 
            // tcEcole
            // 
            this.tcEcole.Controls.Add(this.tpClasses);
            this.tcEcole.Controls.Add(this.tpEleves);
            this.tcEcole.Controls.Add(this.tpInscriptions);
            this.tcEcole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEcole.Location = new System.Drawing.Point(0, 0);
            this.tcEcole.Name = "tcEcole";
            this.tcEcole.SelectedIndex = 0;
            this.tcEcole.Size = new System.Drawing.Size(772, 423);
            this.tcEcole.TabIndex = 0;
            this.tcEcole.SelectedIndexChanged += new System.EventHandler(this.tcEcole_SelectedIndexChanged);
            // 
            // tpClasses
            // 
            this.tpClasses.Controls.Add(this.dgvSalleClasses);
            this.tpClasses.Location = new System.Drawing.Point(4, 24);
            this.tpClasses.Name = "tpClasses";
            this.tpClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasses.Size = new System.Drawing.Size(764, 395);
            this.tpClasses.TabIndex = 0;
            this.tpClasses.Text = "Salle de classes";
            this.tpClasses.UseVisualStyleBackColor = true;
            // 
            // dgvSalleClasses
            // 
            this.dgvSalleClasses.AllowUserToAddRows = false;
            this.dgvSalleClasses.AllowUserToDeleteRows = false;
            this.dgvSalleClasses.AllowUserToResizeRows = false;
            this.dgvSalleClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalleClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalleClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalleClasses.Location = new System.Drawing.Point(3, 3);
            this.dgvSalleClasses.MultiSelect = false;
            this.dgvSalleClasses.Name = "dgvSalleClasses";
            this.dgvSalleClasses.RowHeadersVisible = false;
            this.dgvSalleClasses.RowTemplate.Height = 25;
            this.dgvSalleClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalleClasses.Size = new System.Drawing.Size(758, 389);
            this.dgvSalleClasses.TabIndex = 0;
            // 
            // tpEleves
            // 
            this.tpEleves.Controls.Add(this.pnlEleveData);
            this.tpEleves.Controls.Add(this.pnlHeaderEleve);
            this.tpEleves.Location = new System.Drawing.Point(4, 24);
            this.tpEleves.Name = "tpEleves";
            this.tpEleves.Size = new System.Drawing.Size(764, 395);
            this.tpEleves.TabIndex = 1;
            this.tpEleves.Text = "Elèves inscrits";
            this.tpEleves.UseVisualStyleBackColor = true;
            // 
            // pnlEleveData
            // 
            this.pnlEleveData.Controls.Add(this.dgvEleves);
            this.pnlEleveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEleveData.Location = new System.Drawing.Point(0, 23);
            this.pnlEleveData.Name = "pnlEleveData";
            this.pnlEleveData.Size = new System.Drawing.Size(764, 372);
            this.pnlEleveData.TabIndex = 1;
            // 
            // dgvEleves
            // 
            this.dgvEleves.AllowUserToAddRows = false;
            this.dgvEleves.AllowUserToDeleteRows = false;
            this.dgvEleves.AllowUserToResizeRows = false;
            this.dgvEleves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEleves.Location = new System.Drawing.Point(0, 0);
            this.dgvEleves.MultiSelect = false;
            this.dgvEleves.Name = "dgvEleves";
            this.dgvEleves.RowHeadersVisible = false;
            this.dgvEleves.RowTemplate.Height = 25;
            this.dgvEleves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEleves.Size = new System.Drawing.Size(764, 372);
            this.dgvEleves.TabIndex = 0;
            // 
            // pnlHeaderEleve
            // 
            this.pnlHeaderEleve.Controls.Add(this.cbClasses);
            this.pnlHeaderEleve.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderEleve.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderEleve.Name = "pnlHeaderEleve";
            this.pnlHeaderEleve.Size = new System.Drawing.Size(764, 23);
            this.pnlHeaderEleve.TabIndex = 2;
            // 
            // cbClasses
            // 
            this.cbClasses.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(0, 0);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(197, 23);
            this.cbClasses.TabIndex = 0;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // tpInscriptions
            // 
            this.tpInscriptions.Controls.Add(this.dgvInscriptions);
            this.tpInscriptions.Location = new System.Drawing.Point(4, 24);
            this.tpInscriptions.Name = "tpInscriptions";
            this.tpInscriptions.Size = new System.Drawing.Size(764, 395);
            this.tpInscriptions.TabIndex = 2;
            this.tpInscriptions.Text = "Inscriptions de l\'année en cours";
            this.tpInscriptions.UseVisualStyleBackColor = true;
            // 
            // dgvInscriptions
            // 
            this.dgvInscriptions.AllowUserToAddRows = false;
            this.dgvInscriptions.AllowUserToDeleteRows = false;
            this.dgvInscriptions.AllowUserToResizeRows = false;
            this.dgvInscriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscriptions.Location = new System.Drawing.Point(0, 0);
            this.dgvInscriptions.MultiSelect = false;
            this.dgvInscriptions.Name = "dgvInscriptions";
            this.dgvInscriptions.RowHeadersVisible = false;
            this.dgvInscriptions.RowTemplate.Height = 25;
            this.dgvInscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscriptions.Size = new System.Drawing.Size(764, 395);
            this.dgvInscriptions.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(772, 36);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 459);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(772, 42);
            this.pnlFooter.TabIndex = 3;
            // 
            // EcoleActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "EcoleActions";
            this.Size = new System.Drawing.Size(772, 501);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tcEcole.ResumeLayout(false);
            this.tpClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalleClasses)).EndInit();
            this.tpEleves.ResumeLayout(false);
            this.pnlEleveData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).EndInit();
            this.pnlHeaderEleve.ResumeLayout(false);
            this.tpInscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tcEcole;
        private System.Windows.Forms.TabPage tpClasses;
        private System.Windows.Forms.TabPage tpEleves;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dgvSalleClasses;
        private System.Windows.Forms.DataGridView dgvEleves;
        private System.Windows.Forms.Panel pnlEleveData;
        private System.Windows.Forms.Panel pnlHeaderEleve;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.TabPage tpInscriptions;
        private System.Windows.Forms.DataGridView dgvInscriptions;
    }
}
