
namespace bd_sql
{
    partial class sql_bd
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
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.GBServer = new System.Windows.Forms.GroupBox();
            this.BTNConnect = new System.Windows.Forms.Button();
            this.GBActions = new System.Windows.Forms.GroupBox();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNCreate = new System.Windows.Forms.Button();
            this.BTNCreateTable = new System.Windows.Forms.Button();
            this.DGridData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBServer.SuspendLayout();
            this.GBActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLName.Location = new System.Drawing.Point(18, 18);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(41, 21);
            this.LBLName.TabIndex = 1;
            this.LBLName.Text = "Name:";
            this.LBLName.UseCompatibleTextRendering = true;
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.Location = new System.Drawing.Point(18, 58);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(44, 15);
            this.LBLEmail.TabIndex = 2;
            this.LBLEmail.Text = "E-mail:";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(62, 15);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(222, 20);
            this.TBName.TabIndex = 3;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(62, 55);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(222, 20);
            this.TBEmail.TabIndex = 4;
            // 
            // GBServer
            // 
            this.GBServer.Controls.Add(this.BTNConnect);
            this.GBServer.Location = new System.Drawing.Point(21, 100);
            this.GBServer.Name = "GBServer";
            this.GBServer.Size = new System.Drawing.Size(92, 72);
            this.GBServer.TabIndex = 5;
            this.GBServer.TabStop = false;
            this.GBServer.Text = "SQL Server";
            // 
            // BTNConnect
            // 
            this.BTNConnect.BackColor = System.Drawing.SystemColors.Info;
            this.BTNConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConnect.Location = new System.Drawing.Point(8, 17);
            this.BTNConnect.Name = "BTNConnect";
            this.BTNConnect.Size = new System.Drawing.Size(76, 46);
            this.BTNConnect.TabIndex = 1;
            this.BTNConnect.Text = "Connect Database";
            this.BTNConnect.UseVisualStyleBackColor = false;
            this.BTNConnect.Click += new System.EventHandler(this.BTNConnect_Click);
            // 
            // GBActions
            // 
            this.GBActions.Controls.Add(this.BTNEdit);
            this.GBActions.Controls.Add(this.BTNDelete);
            this.GBActions.Controls.Add(this.BTNSearch);
            this.GBActions.Controls.Add(this.BTNCreate);
            this.GBActions.Controls.Add(this.BTNCreateTable);
            this.GBActions.Location = new System.Drawing.Point(130, 100);
            this.GBActions.Name = "GBActions";
            this.GBActions.Size = new System.Drawing.Size(154, 102);
            this.GBActions.TabIndex = 7;
            this.GBActions.TabStop = false;
            this.GBActions.Text = "Actions";
            // 
            // BTNEdit
            // 
            this.BTNEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNEdit.Location = new System.Drawing.Point(77, 69);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(69, 24);
            this.BTNEdit.TabIndex = 10;
            this.BTNEdit.Text = "Edit";
            this.BTNEdit.UseVisualStyleBackColor = false;
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNDelete.Location = new System.Drawing.Point(6, 69);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(69, 24);
            this.BTNDelete.TabIndex = 9;
            this.BTNDelete.Text = "Delete";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNSearch.Location = new System.Drawing.Point(77, 43);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(69, 24);
            this.BTNSearch.TabIndex = 8;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNCreate
            // 
            this.BTNCreate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNCreate.Location = new System.Drawing.Point(6, 43);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(69, 24);
            this.BTNCreate.TabIndex = 7;
            this.BTNCreate.Text = "Insert";
            this.BTNCreate.UseVisualStyleBackColor = false;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNCreateTable
            // 
            this.BTNCreateTable.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateTable.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreateTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNCreateTable.Location = new System.Drawing.Point(6, 17);
            this.BTNCreateTable.Name = "BTNCreateTable";
            this.BTNCreateTable.Size = new System.Drawing.Size(142, 24);
            this.BTNCreateTable.TabIndex = 6;
            this.BTNCreateTable.Text = "Create Table";
            this.BTNCreateTable.UseVisualStyleBackColor = false;
            this.BTNCreateTable.Click += new System.EventHandler(this.BTNCreateTable_Click);
            // 
            // DGridData
            // 
            this.DGridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGridData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.email});
            this.DGridData.Location = new System.Drawing.Point(307, 14);
            this.DGridData.Name = "DGridData";
            this.DGridData.Size = new System.Drawing.Size(344, 188);
            this.DGridData.TabIndex = 8;
            this.DGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridData_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // name
            // 
            this.name.HeaderText = "Name:";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "E-mail:";
            this.email.Name = "email";
            // 
            // sql_bd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(670, 219);
            this.Controls.Add(this.DGridData);
            this.Controls.Add(this.GBActions);
            this.Controls.Add(this.GBServer);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LBLEmail);
            this.Controls.Add(this.LBLName);
            this.Name = "sql_bd";
            this.ShowIcon = false;
            this.Text = "Conexão com Banco de Dados (SQL)";
            this.GBServer.ResumeLayout(false);
            this.GBActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.GroupBox GBServer;
        private System.Windows.Forms.Button BTNConnect;
        private System.Windows.Forms.GroupBox GBActions;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNCreate;
        private System.Windows.Forms.Button BTNCreateTable;
        private System.Windows.Forms.DataGridView DGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}

