
namespace Sukulu.Desktop.SKLAdmin.Controls
{
    partial class ClientsEcoleUtilisateursResourcesActions
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
            this.tcUtilisateurs = new System.Windows.Forms.TabControl();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tpEcoles = new System.Windows.Forms.TabPage();
            this.pnlEcolesPerClient = new System.Windows.Forms.Panel();
            this.dgvEcoles = new System.Windows.Forms.DataGridView();
            this.pnlSelectClient = new System.Windows.Forms.Panel();
            this.cbClientsForEcoles = new System.Windows.Forms.ComboBox();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbClientsForUsers = new System.Windows.Forms.ComboBox();
            this.cbEcolesForUsers = new System.Windows.Forms.ComboBox();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlUsersAndResources = new System.Windows.Forms.Panel();
            this.cbEcoleForResources = new System.Windows.Forms.ComboBox();
            this.cbUsersForResources = new System.Windows.Forms.ComboBox();
            this.cbClientsForResources = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tcUtilisateurs.SuspendLayout();
            this.tpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tpEcoles.SuspendLayout();
            this.pnlEcolesPerClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcoles)).BeginInit();
            this.pnlSelectClient.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpResources.SuspendLayout();
            this.pnlUsersAndResources.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(858, 512);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tcUtilisateurs);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(858, 434);
            this.pnlBody.TabIndex = 1;
            // 
            // tcUtilisateurs
            // 
            this.tcUtilisateurs.Controls.Add(this.tpClients);
            this.tcUtilisateurs.Controls.Add(this.tpEcoles);
            this.tcUtilisateurs.Controls.Add(this.tpUsers);
            this.tcUtilisateurs.Controls.Add(this.tpResources);
            this.tcUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUtilisateurs.Location = new System.Drawing.Point(0, 0);
            this.tcUtilisateurs.Name = "tcUtilisateurs";
            this.tcUtilisateurs.SelectedIndex = 0;
            this.tcUtilisateurs.Size = new System.Drawing.Size(858, 434);
            this.tcUtilisateurs.TabIndex = 0;
            this.tcUtilisateurs.SelectedIndexChanged += new System.EventHandler(this.tcUtilisateurs_SelectedIndexChanged);
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.dgvClients);
            this.tpClients.Location = new System.Drawing.Point(4, 24);
            this.tpClients.Name = "tpClients";
            this.tpClients.Size = new System.Drawing.Size(850, 406);
            this.tpClients.TabIndex = 1;
            this.tpClients.Text = "Clients";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 0);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowTemplate.Height = 25;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(850, 406);
            this.dgvClients.TabIndex = 0;
            // 
            // tpEcoles
            // 
            this.tpEcoles.Controls.Add(this.pnlEcolesPerClient);
            this.tpEcoles.Controls.Add(this.pnlSelectClient);
            this.tpEcoles.Location = new System.Drawing.Point(4, 24);
            this.tpEcoles.Name = "tpEcoles";
            this.tpEcoles.Size = new System.Drawing.Size(850, 406);
            this.tpEcoles.TabIndex = 2;
            this.tpEcoles.Text = "Ecoles (Par Client)";
            this.tpEcoles.UseVisualStyleBackColor = true;
            // 
            // pnlEcolesPerClient
            // 
            this.pnlEcolesPerClient.Controls.Add(this.dgvEcoles);
            this.pnlEcolesPerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEcolesPerClient.Location = new System.Drawing.Point(0, 23);
            this.pnlEcolesPerClient.Name = "pnlEcolesPerClient";
            this.pnlEcolesPerClient.Size = new System.Drawing.Size(850, 383);
            this.pnlEcolesPerClient.TabIndex = 0;
            // 
            // dgvEcoles
            // 
            this.dgvEcoles.AllowUserToAddRows = false;
            this.dgvEcoles.AllowUserToDeleteRows = false;
            this.dgvEcoles.AllowUserToResizeRows = false;
            this.dgvEcoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEcoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEcoles.Location = new System.Drawing.Point(0, 0);
            this.dgvEcoles.MultiSelect = false;
            this.dgvEcoles.Name = "dgvEcoles";
            this.dgvEcoles.RowHeadersVisible = false;
            this.dgvEcoles.RowTemplate.Height = 25;
            this.dgvEcoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEcoles.Size = new System.Drawing.Size(850, 383);
            this.dgvEcoles.TabIndex = 0;
            // 
            // pnlSelectClient
            // 
            this.pnlSelectClient.Controls.Add(this.cbClientsForEcoles);
            this.pnlSelectClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectClient.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectClient.Name = "pnlSelectClient";
            this.pnlSelectClient.Size = new System.Drawing.Size(850, 23);
            this.pnlSelectClient.TabIndex = 1;
            // 
            // cbClientsForEcoles
            // 
            this.cbClientsForEcoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbClientsForEcoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsForEcoles.FormattingEnabled = true;
            this.cbClientsForEcoles.Location = new System.Drawing.Point(0, 0);
            this.cbClientsForEcoles.Name = "cbClientsForEcoles";
            this.cbClientsForEcoles.Size = new System.Drawing.Size(320, 23);
            this.cbClientsForEcoles.TabIndex = 0;
            this.cbClientsForEcoles.SelectedIndexChanged += new System.EventHandler(this.cbClientsForEcoles_SelectedIndexChanged);
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.panel2);
            this.tpUsers.Controls.Add(this.panel1);
            this.tpUsers.Location = new System.Drawing.Point(4, 24);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Size = new System.Drawing.Size(850, 406);
            this.tpUsers.TabIndex = 3;
            this.tpUsers.Text = "Utilisateurs (Par Ecole)";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 383);
            this.panel2.TabIndex = 3;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(850, 383);
            this.dgvUsers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbClientsForUsers);
            this.panel1.Controls.Add(this.cbEcolesForUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 23);
            this.panel1.TabIndex = 2;
            // 
            // cbClientsForUsers
            // 
            this.cbClientsForUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbClientsForUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsForUsers.FormattingEnabled = true;
            this.cbClientsForUsers.Location = new System.Drawing.Point(0, 0);
            this.cbClientsForUsers.Name = "cbClientsForUsers";
            this.cbClientsForUsers.Size = new System.Drawing.Size(320, 23);
            this.cbClientsForUsers.TabIndex = 1;
            this.cbClientsForUsers.SelectedIndexChanged += new System.EventHandler(this.cbClientsForUsers_SelectedIndexChanged);
            // 
            // cbEcolesForUsers
            // 
            this.cbEcolesForUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcolesForUsers.FormattingEnabled = true;
            this.cbEcolesForUsers.Location = new System.Drawing.Point(326, 0);
            this.cbEcolesForUsers.Name = "cbEcolesForUsers";
            this.cbEcolesForUsers.Size = new System.Drawing.Size(220, 23);
            this.cbEcolesForUsers.TabIndex = 0;
            this.cbEcolesForUsers.SelectedIndexChanged += new System.EventHandler(this.cbEcolesForUsers_SelectedIndexChanged);
            // 
            // tpResources
            // 
            this.tpResources.Controls.Add(this.panel3);
            this.tpResources.Controls.Add(this.pnlUsersAndResources);
            this.tpResources.Location = new System.Drawing.Point(4, 24);
            this.tpResources.Name = "tpResources";
            this.tpResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResources.Size = new System.Drawing.Size(850, 406);
            this.tpResources.TabIndex = 0;
            this.tpResources.Text = "Resources ( Par Utilisateurs )";
            this.tpResources.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(858, 36);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 470);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(858, 42);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlUsersAndResources
            // 
            this.pnlUsersAndResources.Controls.Add(this.cbClientsForResources);
            this.pnlUsersAndResources.Controls.Add(this.cbUsersForResources);
            this.pnlUsersAndResources.Controls.Add(this.cbEcoleForResources);
            this.pnlUsersAndResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsersAndResources.Location = new System.Drawing.Point(3, 3);
            this.pnlUsersAndResources.Name = "pnlUsersAndResources";
            this.pnlUsersAndResources.Size = new System.Drawing.Size(844, 23);
            this.pnlUsersAndResources.TabIndex = 2;
            // 
            // cbEcoleForResources
            // 
            this.cbEcoleForResources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcoleForResources.FormattingEnabled = true;
            this.cbEcoleForResources.Location = new System.Drawing.Point(326, -1);
            this.cbEcoleForResources.Name = "cbEcoleForResources";
            this.cbEcoleForResources.Size = new System.Drawing.Size(220, 23);
            this.cbEcoleForResources.TabIndex = 0;
            this.cbEcoleForResources.SelectedIndexChanged += new System.EventHandler(this.cbEcoleForResources_SelectedIndexChanged);
            // 
            // cbUsersForResources
            // 
            this.cbUsersForResources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersForResources.FormattingEnabled = true;
            this.cbUsersForResources.Location = new System.Drawing.Point(552, -1);
            this.cbUsersForResources.Name = "cbUsersForResources";
            this.cbUsersForResources.Size = new System.Drawing.Size(244, 23);
            this.cbUsersForResources.TabIndex = 1;
            this.cbUsersForResources.SelectedIndexChanged += new System.EventHandler(this.cbUsersForResources_SelectedIndexChanged);
            // 
            // cbClientsForResources
            // 
            this.cbClientsForResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbClientsForResources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientsForResources.FormattingEnabled = true;
            this.cbClientsForResources.Location = new System.Drawing.Point(0, 0);
            this.cbClientsForResources.Name = "cbClientsForResources";
            this.cbClientsForResources.Size = new System.Drawing.Size(320, 23);
            this.cbClientsForResources.TabIndex = 2;
            this.cbClientsForResources.SelectedIndexChanged += new System.EventHandler(this.cbClientsForResources_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvResources);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 377);
            this.panel3.TabIndex = 3;
            // 
            // dgvResources
            // 
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.AllowUserToDeleteRows = false;
            this.dgvResources.AllowUserToResizeRows = false;
            this.dgvResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResources.Location = new System.Drawing.Point(0, 0);
            this.dgvResources.MultiSelect = false;
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.RowHeadersVisible = false;
            this.dgvResources.RowTemplate.Height = 25;
            this.dgvResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResources.Size = new System.Drawing.Size(844, 377);
            this.dgvResources.TabIndex = 0;
            // 
            // ClientsEcoleUtilisateursResourcesActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ClientsEcoleUtilisateursResourcesActions";
            this.Size = new System.Drawing.Size(858, 512);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tcUtilisateurs.ResumeLayout(false);
            this.tpClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tpEcoles.ResumeLayout(false);
            this.pnlEcolesPerClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcoles)).EndInit();
            this.pnlSelectClient.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpResources.ResumeLayout(false);
            this.pnlUsersAndResources.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabControl tcUtilisateurs;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TabPage tpEcoles;
        private System.Windows.Forms.Panel pnlEcolesPerClient;
        private System.Windows.Forms.DataGridView dgvEcoles;
        private System.Windows.Forms.Panel pnlSelectClient;
        private System.Windows.Forms.ComboBox cbClientsForEcoles;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEcolesForUsers;
        private System.Windows.Forms.ComboBox cbClientsForUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Panel pnlUsersAndResources;
        private System.Windows.Forms.ComboBox cbClientsForResources;
        private System.Windows.Forms.ComboBox cbUsersForResources;
        private System.Windows.Forms.ComboBox cbEcoleForResources;
    }
}
