
namespace cadastro_bd
{
    partial class formCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(27, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(27, 99);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(32, 17);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(139, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 17);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(30, 119);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(106, 22);
            this.tbCPF.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(30, 68);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(142, 119);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(107, 22);
            this.tbTel.TabIndex = 6;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnDelete);
            this.gbActions.Controls.Add(this.btnConsultar);
            this.gbActions.Controls.Add(this.btnRefresh);
            this.gbActions.Controls.Add(this.btnSave);
            this.gbActions.Location = new System.Drawing.Point(265, 15);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(107, 141);
            this.gbActions.TabIndex = 11;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Ações:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(17, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(17, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(17, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(17, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 169);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formCadastro";
            this.ShowIcon = false;
            this.Text = "Cadastro de Clientes";
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
    }
}

