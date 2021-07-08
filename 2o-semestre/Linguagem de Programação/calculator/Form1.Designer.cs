
namespace calculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.tbPNum = new System.Windows.Forms.TextBox();
            this.tbSNum = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.linkCalc = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salvarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(27, 36);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(65, 19);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(24, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "NASA Scientific Calculator Advanced Plus+";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(24, 99);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(105, 13);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Digite o 1º número:";
            // 
            // tbPNum
            // 
            this.tbPNum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPNum.Location = new System.Drawing.Point(135, 95);
            this.tbPNum.Name = "tbPNum";
            this.tbPNum.Size = new System.Drawing.Size(113, 23);
            this.tbPNum.TabIndex = 3;
            this.tbPNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPNum.TextChanged += new System.EventHandler(this.tbPNum_TextChanged);
            this.tbPNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPNum_KeyUp);
            // 
            // tbSNum
            // 
            this.tbSNum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSNum.Location = new System.Drawing.Point(135, 124);
            this.tbSNum.Name = "tbSNum";
            this.tbSNum.Size = new System.Drawing.Size(113, 23);
            this.tbSNum.TabIndex = 5;
            this.tbSNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(24, 128);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(107, 13);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Digite o 2º número:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(35, 168);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(124, 13);
            this.lblOperacao.TabIndex = 6;
            this.lblOperacao.Text = "Escolha uma operação:";
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSoma.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoma.Location = new System.Drawing.Point(36, 190);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(96, 36);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.Text = "SOMA";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSub.Location = new System.Drawing.Point(138, 190);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(112, 36);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "SUBTRAÇÃO";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(36, 232);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(96, 36);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "DIVISÃO";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMult.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMult.Location = new System.Drawing.Point(138, 232);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(112, 36);
            this.btnMult.TabIndex = 10;
            this.btnMult.Text = "MULTIPLICAÇÃO";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(109, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Resultado:";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tbResult.Location = new System.Drawing.Point(36, 298);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(212, 23);
            this.tbResult.TabIndex = 12;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkCalc
            // 
            this.linkCalc.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkCalc.AutoSize = true;
            this.linkCalc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkCalc.Location = new System.Drawing.Point(36, 329);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(214, 13);
            this.linkCalc.TabIndex = 13;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Abrir uma calculadora mais simples [link]";
            this.linkCalc.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.salvarComoToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Fechar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // salvarComoToolStripMenuItem1
            // 
            this.salvarComoToolStripMenuItem1.Name = "salvarComoToolStripMenuItem1";
            this.salvarComoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salvarComoToolStripMenuItem1.Text = "Salvar";
            this.salvarComoToolStripMenuItem1.Click += new System.EventHandler(this.salvarComoToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.chromeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.blocoDeNotasToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.editarToolStripMenuItem.Text = "Aplicativos";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.linkCalc);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.tbSNum);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.tbPNum);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "calculator";
            this.ShowIcon = false;
            this.Text = "NASA Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox tbPNum;
        private System.Windows.Forms.TextBox tbSNum;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.LinkLabel linkCalc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

