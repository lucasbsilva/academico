
namespace calculator
{
    partial class fmrCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCalculator));
            this.lblPNum = new System.Windows.Forms.Label();
            this.tbPNum = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tbSNum = new System.Windows.Forms.TextBox();
            this.lblSNum = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPNum
            // 
            this.lblPNum.AutoSize = true;
            this.lblPNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPNum.Location = new System.Drawing.Point(19, 88);
            this.lblPNum.Name = "lblPNum";
            this.lblPNum.Size = new System.Drawing.Size(108, 15);
            this.lblPNum.TabIndex = 0;
            this.lblPNum.Text = "Digite um número:";
            // 
            // tbPNum
            // 
            this.tbPNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbPNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPNum.Location = new System.Drawing.Point(144, 83);
            this.tbPNum.Name = "tbPNum";
            this.tbPNum.Size = new System.Drawing.Size(129, 25);
            this.tbPNum.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(19, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "NASA Scientific Calculator Advanced Plus+";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(22, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(67, 20);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // tbSNum
            // 
            this.tbSNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSNum.Location = new System.Drawing.Point(144, 114);
            this.tbSNum.Name = "tbSNum";
            this.tbSNum.Size = new System.Drawing.Size(129, 25);
            this.tbSNum.TabIndex = 5;
            // 
            // lblSNum
            // 
            this.lblSNum.AutoSize = true;
            this.lblSNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSNum.Location = new System.Drawing.Point(19, 119);
            this.lblSNum.Name = "lblSNum";
            this.lblSNum.Size = new System.Drawing.Size(119, 15);
            this.lblSNum.TabIndex = 4;
            this.lblSNum.Text = "Digite outro número:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOperacao.Location = new System.Drawing.Point(73, 165);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperacao.Size = new System.Drawing.Size(151, 19);
            this.lblOperacao.TabIndex = 6;
            this.lblOperacao.Text = "Escolha uma operação:";
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSoma.Location = new System.Drawing.Point(41, 193);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(99, 34);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.Text = "SOMA";
            this.btnSoma.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSub.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSub.Location = new System.Drawing.Point(146, 193);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(99, 34);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "SUBTRAÇÃO";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMult.Location = new System.Drawing.Point(41, 233);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(99, 34);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "MULTIPLICAÇÃO";
            this.btnMult.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDiv.Location = new System.Drawing.Point(146, 233);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(99, 34);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "DIVISÃO";
            this.btnDiv.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblResult.Location = new System.Drawing.Point(67, 288);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(154, 19);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Resultado da operação:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tbResult.Location = new System.Drawing.Point(41, 311);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(204, 25);
            this.tbResult.TabIndex = 12;
            this.tbResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // fmrCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.tbSNum);
            this.Controls.Add(this.lblSNum);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbPNum);
            this.Controls.Add(this.lblPNum);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmrCalculator";
            this.ShowIcon = false;
            this.Text = "NASA Scientific Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPNum;
        private System.Windows.Forms.TextBox tbPNum;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox tbSNum;
        private System.Windows.Forms.Label lblSNum;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

