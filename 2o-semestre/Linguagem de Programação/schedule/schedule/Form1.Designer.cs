
namespace schedule
{
    partial class frmSchedule
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone01 = new System.Windows.Forms.TextBox();
            this.lblPhone01 = new System.Windows.Forms.Label();
            this.txtPhone02 = new System.Windows.Forms.TextBox();
            this.lblPhone02 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblByName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add a contact on your schedule:";
            // 
            // picIcon
            // 
            this.picIcon.Image = global::schedule.Properties.Resources.contact_book;
            this.picIcon.Location = new System.Drawing.Point(40, 55);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(41, 39);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(84, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(87, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAddress.Location = new System.Drawing.Point(87, 185);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(327, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(84, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Complete address:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmail.Location = new System.Drawing.Point(87, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(84, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtPhone01
            // 
            this.txtPhone01.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone01.Location = new System.Drawing.Point(87, 297);
            this.txtPhone01.Name = "txtPhone01";
            this.txtPhone01.Size = new System.Drawing.Size(152, 20);
            this.txtPhone01.TabIndex = 9;
            // 
            // lblPhone01
            // 
            this.lblPhone01.AutoSize = true;
            this.lblPhone01.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone01.Location = new System.Drawing.Point(84, 277);
            this.lblPhone01.Name = "lblPhone01";
            this.lblPhone01.Size = new System.Drawing.Size(59, 15);
            this.lblPhone01.TabIndex = 8;
            this.lblPhone01.Text = "Phone 01:";
            // 
            // txtPhone02
            // 
            this.txtPhone02.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone02.Location = new System.Drawing.Point(262, 297);
            this.txtPhone02.Name = "txtPhone02";
            this.txtPhone02.Size = new System.Drawing.Size(152, 20);
            this.txtPhone02.TabIndex = 11;
            // 
            // lblPhone02
            // 
            this.lblPhone02.AutoSize = true;
            this.lblPhone02.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone02.Location = new System.Drawing.Point(259, 277);
            this.lblPhone02.Name = "lblPhone02";
            this.lblPhone02.Size = new System.Drawing.Size(61, 15);
            this.lblPhone02.TabIndex = 10;
            this.lblPhone02.Text = "Phone 02:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(344, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 26);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(262, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(87, 334);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 26);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(134, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 26);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnConsult);
            this.grpSearch.Controls.Add(this.dgvSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblByName);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(445, 55);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(315, 304);
            this.grpSearch.TabIndex = 17;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Contact";
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsult.Location = new System.Drawing.Point(83, 61);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(207, 26);
            this.btnConsult.TabIndex = 18;
            this.btnConsult.Text = "Consult";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.address,
            this.email,
            this.phone01,
            this.phone02});
            this.dgvSearch.Location = new System.Drawing.Point(26, 96);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(264, 182);
            this.dgvSearch.TabIndex = 20;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Name:";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "Address:";
            this.address.Name = "address";
            this.address.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail:";
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // phone01
            // 
            this.phone01.HeaderText = "Phone 01:";
            this.phone01.Name = "phone01";
            // 
            // phone02
            // 
            this.phone02.HeaderText = "Phone 02:";
            this.phone02.Name = "phone02";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearch.Location = new System.Drawing.Point(83, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblByName
            // 
            this.lblByName.AutoSize = true;
            this.lblByName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByName.Location = new System.Drawing.Point(21, 35);
            this.lblByName.Name = "lblByName";
            this.lblByName.Size = new System.Drawing.Size(56, 15);
            this.lblByName.TabIndex = 18;
            this.lblByName.Text = "by name:";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 401);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone02);
            this.Controls.Add(this.lblPhone02);
            this.Controls.Add(this.txtPhone01);
            this.Controls.Add(this.lblPhone01);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(815, 440);
            this.MinimumSize = new System.Drawing.Size(815, 440);
            this.Name = "frmSchedule";
            this.ShowIcon = false;
            this.Text = "My Schedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone01;
        private System.Windows.Forms.Label lblPhone01;
        private System.Windows.Forms.TextBox txtPhone02;
        private System.Windows.Forms.Label lblPhone02;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblByName;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone01;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone02;
    }
}

