
namespace addemployed
{
    partial class frmAdd
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
            this.lblDepartament = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.cboChildren = new System.Windows.Forms.ComboBox();
            this.cboSalary = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartament.Location = new System.Drawing.Point(121, 64);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(116, 17);
            this.lblDepartament.TabIndex = 0;
            this.lblDepartament.Text = "human Resources";
            this.lblDepartament.Click += new System.EventHandler(this.label1_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::addemployed.Properties.Resources.follow;
            this.picIcon.Location = new System.Drawing.Point(52, 43);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(60, 62);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(119, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add employee";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Location = new System.Drawing.Point(52, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(49, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Complete name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(49, 201);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(118, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Complete address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddress.Location = new System.Drawing.Point(52, 221);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(391, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChildren.Location = new System.Drawing.Point(49, 257);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(59, 17);
            this.lblChildren.TabIndex = 7;
            this.lblChildren.Text = "Children:";
            // 
            // cboChildren
            // 
            this.cboChildren.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboChildren.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChildren.ForeColor = System.Drawing.SystemColors.Window;
            this.cboChildren.FormattingEnabled = true;
            this.cboChildren.Items.AddRange(new object[] {
            "No",
            "01",
            "02",
            "03",
            "04",
            "05",
            "More"});
            this.cboChildren.Location = new System.Drawing.Point(110, 254);
            this.cboChildren.Name = "cboChildren";
            this.cboChildren.Size = new System.Drawing.Size(63, 25);
            this.cboChildren.TabIndex = 8;
            // 
            // cboSalary
            // 
            this.cboSalary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSalary.ForeColor = System.Drawing.SystemColors.Window;
            this.cboSalary.FormattingEnabled = true;
            this.cboSalary.Items.AddRange(new object[] {
            "R$ 0,00 to R$ 1.000,00",
            "R$ 1.000,01 to R$ 3.000,00",
            "R$ 3.000,01 to R$ 5.000,00",
            "R$ 5.000,01 to R$ 7.000,00",
            "R$ 7.000,01 to R$ 10.000,00",
            "More"});
            this.cboSalary.Location = new System.Drawing.Point(266, 257);
            this.cboSalary.Name = "cboSalary";
            this.cboSalary.Size = new System.Drawing.Size(177, 23);
            this.cboSalary.TabIndex = 10;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalary.Location = new System.Drawing.Point(181, 258);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(84, 17);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary range:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(391, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 27);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(315, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(52, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 27);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(114, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 27);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.dgvData);
            this.grpSearch.Controls.Add(this.btnConsult);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSearch.Location = new System.Drawing.Point(465, 43);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(300, 302);
            this.grpSearch.TabIndex = 15;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search employee";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(17, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 17);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "by name:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.Location = new System.Drawing.Point(81, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 23);
            this.txtSearch.TabIndex = 16;
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsult.Location = new System.Drawing.Point(81, 51);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(202, 24);
            this.btnConsult.TabIndex = 16;
            this.btnConsult.Text = "Consult";
            this.btnConsult.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(20, 85);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(262, 198);
            this.dgvData.TabIndex = 18;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cboChildren);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblDepartament);
            this.Name = "frmAdd";
            this.ShowIcon = false;
            this.Text = "OS Corporation";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ComboBox cboChildren;
        private System.Windows.Forms.ComboBox cboSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

