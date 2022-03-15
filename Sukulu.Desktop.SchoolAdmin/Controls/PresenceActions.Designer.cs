
namespace Sukulu.Desktop.SchoolAdmin.Controls
{
    partial class PresenceActions
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
            this.pnlPresences = new System.Windows.Forms.Panel();
            this.pnlPresencesEleves = new System.Windows.Forms.Panel();
            this.dgvPresences = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlElevesCodePresences = new System.Windows.Forms.Panel();
            this.pnlComboBoxSend = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCodePresences = new System.Windows.Forms.ComboBox();
            this.pnlLbEleves = new System.Windows.Forms.Panel();
            this.lbEleves = new System.Windows.Forms.ListBox();
            this.cbSelectAllEleves = new System.Windows.Forms.CheckBox();
            this.pnlSalleClasseDateMatiere = new System.Windows.Forms.Panel();
            this.cbCoursPrevus = new System.Windows.Forms.ComboBox();
            this.dtpPresenceDate = new System.Windows.Forms.DateTimePicker();
            this.cbSalleClasses = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPresences.SuspendLayout();
            this.pnlPresencesEleves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresences)).BeginInit();
            this.pnlElevesCodePresences.SuspendLayout();
            this.pnlComboBoxSend.SuspendLayout();
            this.pnlLbEleves.SuspendLayout();
            this.pnlSalleClasseDateMatiere.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(861, 493);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlPresences);
            this.pnlBody.Controls.Add(this.pnlSalleClasseDateMatiere);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 39);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(861, 420);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlPresences
            // 
            this.pnlPresences.Controls.Add(this.pnlPresencesEleves);
            this.pnlPresences.Controls.Add(this.pnlElevesCodePresences);
            this.pnlPresences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresences.Location = new System.Drawing.Point(0, 23);
            this.pnlPresences.Name = "pnlPresences";
            this.pnlPresences.Size = new System.Drawing.Size(861, 397);
            this.pnlPresences.TabIndex = 1;
            // 
            // pnlPresencesEleves
            // 
            this.pnlPresencesEleves.Controls.Add(this.dgvPresences);
            this.pnlPresencesEleves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPresencesEleves.Location = new System.Drawing.Point(304, 0);
            this.pnlPresencesEleves.Name = "pnlPresencesEleves";
            this.pnlPresencesEleves.Size = new System.Drawing.Size(557, 397);
            this.pnlPresencesEleves.TabIndex = 1;
            // 
            // dgvPresences
            // 
            this.dgvPresences.AllowUserToAddRows = false;
            this.dgvPresences.AllowUserToDeleteRows = false;
            this.dgvPresences.AllowUserToResizeRows = false;
            this.dgvPresences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Eleve,
            this.Presence});
            this.dgvPresences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresences.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPresences.Location = new System.Drawing.Point(0, 0);
            this.dgvPresences.Name = "dgvPresences";
            this.dgvPresences.RowHeadersVisible = false;
            this.dgvPresences.RowTemplate.Height = 25;
            this.dgvPresences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresences.Size = new System.Drawing.Size(557, 397);
            this.dgvPresences.TabIndex = 0;
            this.dgvPresences.SelectionChanged += new System.EventHandler(this.dgvPresences_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Eleve
            // 
            this.Eleve.HeaderText = "Elève";
            this.Eleve.Name = "Eleve";
            // 
            // Presence
            // 
            this.Presence.HeaderText = "Présence";
            this.Presence.Name = "Presence";
            // 
            // pnlElevesCodePresences
            // 
            this.pnlElevesCodePresences.Controls.Add(this.pnlComboBoxSend);
            this.pnlElevesCodePresences.Controls.Add(this.pnlLbEleves);
            this.pnlElevesCodePresences.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlElevesCodePresences.Location = new System.Drawing.Point(0, 0);
            this.pnlElevesCodePresences.Name = "pnlElevesCodePresences";
            this.pnlElevesCodePresences.Size = new System.Drawing.Size(304, 397);
            this.pnlElevesCodePresences.TabIndex = 0;
            // 
            // pnlComboBoxSend
            // 
            this.pnlComboBoxSend.Controls.Add(this.btnRemove);
            this.pnlComboBoxSend.Controls.Add(this.btnAdd);
            this.pnlComboBoxSend.Controls.Add(this.cbCodePresences);
            this.pnlComboBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComboBoxSend.Location = new System.Drawing.Point(180, 0);
            this.pnlComboBoxSend.Name = "pnlComboBoxSend";
            this.pnlComboBoxSend.Size = new System.Drawing.Size(124, 397);
            this.pnlComboBoxSend.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(38, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 25);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(38, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCodePresences
            // 
            this.cbCodePresences.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCodePresences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodePresences.FormattingEnabled = true;
            this.cbCodePresences.Location = new System.Drawing.Point(0, 0);
            this.cbCodePresences.Name = "cbCodePresences";
            this.cbCodePresences.Size = new System.Drawing.Size(124, 23);
            this.cbCodePresences.TabIndex = 1;
            this.cbCodePresences.SelectedIndexChanged += new System.EventHandler(this.cbCodePresences_SelectedIndexChanged);
            // 
            // pnlLbEleves
            // 
            this.pnlLbEleves.Controls.Add(this.lbEleves);
            this.pnlLbEleves.Controls.Add(this.cbSelectAllEleves);
            this.pnlLbEleves.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLbEleves.Location = new System.Drawing.Point(0, 0);
            this.pnlLbEleves.Name = "pnlLbEleves";
            this.pnlLbEleves.Size = new System.Drawing.Size(180, 397);
            this.pnlLbEleves.TabIndex = 2;
            // 
            // lbEleves
            // 
            this.lbEleves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEleves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEleves.FormattingEnabled = true;
            this.lbEleves.ItemHeight = 15;
            this.lbEleves.Location = new System.Drawing.Point(0, 23);
            this.lbEleves.Name = "lbEleves";
            this.lbEleves.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbEleves.Size = new System.Drawing.Size(180, 374);
            this.lbEleves.TabIndex = 0;
            this.lbEleves.SelectedIndexChanged += new System.EventHandler(this.lbEleves_SelectedIndexChanged);
            // 
            // cbSelectAllEleves
            // 
            this.cbSelectAllEleves.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSelectAllEleves.Location = new System.Drawing.Point(0, 0);
            this.cbSelectAllEleves.Name = "cbSelectAllEleves";
            this.cbSelectAllEleves.Size = new System.Drawing.Size(180, 23);
            this.cbSelectAllEleves.TabIndex = 1;
            this.cbSelectAllEleves.Text = "tout sélectionner";
            this.cbSelectAllEleves.UseVisualStyleBackColor = true;
            this.cbSelectAllEleves.CheckedChanged += new System.EventHandler(this.cbSelectAllEleves_CheckedChanged);
            // 
            // pnlSalleClasseDateMatiere
            // 
            this.pnlSalleClasseDateMatiere.Controls.Add(this.cbCoursPrevus);
            this.pnlSalleClasseDateMatiere.Controls.Add(this.dtpPresenceDate);
            this.pnlSalleClasseDateMatiere.Controls.Add(this.cbSalleClasses);
            this.pnlSalleClasseDateMatiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalleClasseDateMatiere.Location = new System.Drawing.Point(0, 0);
            this.pnlSalleClasseDateMatiere.Name = "pnlSalleClasseDateMatiere";
            this.pnlSalleClasseDateMatiere.Size = new System.Drawing.Size(861, 23);
            this.pnlSalleClasseDateMatiere.TabIndex = 0;
            // 
            // cbCoursPrevus
            // 
            this.cbCoursPrevus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursPrevus.FormattingEnabled = true;
            this.cbCoursPrevus.Location = new System.Drawing.Point(279, 0);
            this.cbCoursPrevus.Name = "cbCoursPrevus";
            this.cbCoursPrevus.Size = new System.Drawing.Size(236, 23);
            this.cbCoursPrevus.TabIndex = 2;
            this.cbCoursPrevus.SelectedIndexChanged += new System.EventHandler(this.cbCoursPrevus_SelectedIndexChanged);
            // 
            // dtpPresenceDate
            // 
            this.dtpPresenceDate.Location = new System.Drawing.Point(121, 0);
            this.dtpPresenceDate.Name = "dtpPresenceDate";
            this.dtpPresenceDate.Size = new System.Drawing.Size(155, 23);
            this.dtpPresenceDate.TabIndex = 1;
            this.dtpPresenceDate.ValueChanged += new System.EventHandler(this.dtpPresenceDate_ValueChanged);
            // 
            // cbSalleClasses
            // 
            this.cbSalleClasses.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSalleClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalleClasses.FormattingEnabled = true;
            this.cbSalleClasses.Location = new System.Drawing.Point(0, 0);
            this.cbSalleClasses.Name = "cbSalleClasses";
            this.cbSalleClasses.Size = new System.Drawing.Size(119, 23);
            this.cbSalleClasses.TabIndex = 0;
            this.cbSalleClasses.SelectedIndexChanged += new System.EventHandler(this.cbSalleClasses_SelectedIndexChanged);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnValidate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 459);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(861, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnValidate.Location = new System.Drawing.Point(0, 0);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(140, 32);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider les présences";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(861, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // PresenceActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "PresenceActions";
            this.Size = new System.Drawing.Size(861, 493);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPresences.ResumeLayout(false);
            this.pnlPresencesEleves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresences)).EndInit();
            this.pnlElevesCodePresences.ResumeLayout(false);
            this.pnlComboBoxSend.ResumeLayout(false);
            this.pnlLbEleves.ResumeLayout(false);
            this.pnlSalleClasseDateMatiere.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlPresences;
        private System.Windows.Forms.Panel pnlSalleClasseDateMatiere;
        private System.Windows.Forms.ComboBox cbCoursPrevus;
        private System.Windows.Forms.DateTimePicker dtpPresenceDate;
        private System.Windows.Forms.ComboBox cbSalleClasses;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Panel pnlPresencesEleves;
        private System.Windows.Forms.Panel pnlElevesCodePresences;
        private System.Windows.Forms.Panel pnlComboBoxSend;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCodePresences;
        private System.Windows.Forms.Panel pnlLbEleves;
        private System.Windows.Forms.ListBox lbEleves;
        private System.Windows.Forms.DataGridView dgvPresences;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presence;
        private System.Windows.Forms.CheckBox cbSelectAllEleves;
    }
}
