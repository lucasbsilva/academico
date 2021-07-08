
namespace interface_wms
{
    partial class frmAddCateg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBK02 = new System.Windows.Forms.PictureBox();
            this.txtNameCateg = new System.Windows.Forms.TextBox();
            this.lblNameCateg = new System.Windows.Forms.Label();
            this.txtDescriptCateg = new System.Windows.Forms.TextBox();
            this.lblDescriptCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(383, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(477, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBK02
            // 
            this.picBK02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBK02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBK02.Location = new System.Drawing.Point(-5, 205);
            this.picBK02.Name = "picBK02";
            this.picBK02.Size = new System.Drawing.Size(593, 59);
            this.picBK02.TabIndex = 15;
            this.picBK02.TabStop = false;
            // 
            // txtNameCateg
            // 
            this.txtNameCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNameCateg.Location = new System.Drawing.Point(44, 51);
            this.txtNameCateg.Name = "txtNameCateg";
            this.txtNameCateg.Size = new System.Drawing.Size(501, 23);
            this.txtNameCateg.TabIndex = 2;
            this.txtNameCateg.Text = "Insira o nome da nova categoria";
            this.txtNameCateg.TextChanged += new System.EventHandler(this.txtNameCateg_TextChanged);
            this.txtNameCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNameCateg_MouseUp);
            // 
            // lblNameCateg
            // 
            this.lblNameCateg.AutoSize = true;
            this.lblNameCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCateg.Location = new System.Drawing.Point(42, 27);
            this.lblNameCateg.Name = "lblNameCateg";
            this.lblNameCateg.Size = new System.Drawing.Size(59, 21);
            this.lblNameCateg.TabIndex = 28;
            this.lblNameCateg.Text = "Nome:";
            // 
            // txtDescriptCateg
            // 
            this.txtDescriptCateg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptCateg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtDescriptCateg.Location = new System.Drawing.Point(44, 114);
            this.txtDescriptCateg.Multiline = true;
            this.txtDescriptCateg.Name = "txtDescriptCateg";
            this.txtDescriptCateg.Size = new System.Drawing.Size(501, 72);
            this.txtDescriptCateg.TabIndex = 3;
            this.txtDescriptCateg.Text = "Escreva uma breve descrição desta categoria";
            this.txtDescriptCateg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtDescriptCateg_MouseUp);
            // 
            // lblDescriptCateg
            // 
            this.lblDescriptCateg.AutoSize = true;
            this.lblDescriptCateg.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptCateg.Location = new System.Drawing.Point(42, 94);
            this.lblDescriptCateg.Name = "lblDescriptCateg";
            this.lblDescriptCateg.Size = new System.Drawing.Size(59, 13);
            this.lblDescriptCateg.TabIndex = 30;
            this.lblDescriptCateg.Text = "Descrição:";
            // 
            // frmAddCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.txtDescriptCateg);
            this.Controls.Add(this.lblDescriptCateg);
            this.Controls.Add(this.txtNameCateg);
            this.Controls.Add(this.lblNameCateg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picBK02);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "frmAddCateg";
            this.ShowIcon = false;
            this.Text = "System Name - Adicionar Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.picBK02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBK02;
        private System.Windows.Forms.TextBox txtNameCateg;
        private System.Windows.Forms.Label lblNameCateg;
        private System.Windows.Forms.TextBox txtDescriptCateg;
        private System.Windows.Forms.Label lblDescriptCateg;
    }
}