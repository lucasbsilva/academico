
namespace formataparagrafo
{
    partial class fonte
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recuos = new System.Windows.Forms.TabPage();
            this.quebras = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPattern = new System.Windows.Forms.Button();
            this.btnEffects = new System.Windows.Forms.Button();
            this.lblFonte = new System.Windows.Forms.Label();
            this.lb01full = new System.Windows.Forms.ListBox();
            this.lb01 = new System.Windows.Forms.ListBox();
            this.lb02 = new System.Windows.Forms.ListBox();
            this.lb02full = new System.Windows.Forms.ListBox();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.lb03 = new System.Windows.Forms.ListBox();
            this.lb03full = new System.Windows.Forms.ListBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.cbFontColor = new System.Windows.Forms.ComboBox();
            this.cbUnderStyle = new System.Windows.Forms.ComboBox();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.cbUnderColor = new System.Windows.Forms.ComboBox();
            this.lblUnderColor = new System.Windows.Forms.Label();
            this.gbEffects = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.recuos.SuspendLayout();
            this.gbEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.recuos);
            this.tabControl1.Controls.Add(this.quebras);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // recuos
            // 
            this.recuos.Controls.Add(this.gbEffects);
            this.recuos.Controls.Add(this.cbUnderColor);
            this.recuos.Controls.Add(this.lblUnderColor);
            this.recuos.Controls.Add(this.cbUnderStyle);
            this.recuos.Controls.Add(this.lblUnderline);
            this.recuos.Controls.Add(this.cbFontColor);
            this.recuos.Controls.Add(this.lblFontColor);
            this.recuos.Controls.Add(this.lb03);
            this.recuos.Controls.Add(this.lb03full);
            this.recuos.Controls.Add(this.lblFontSize);
            this.recuos.Controls.Add(this.lb02);
            this.recuos.Controls.Add(this.lb02full);
            this.recuos.Controls.Add(this.lblFontStyle);
            this.recuos.Controls.Add(this.lb01);
            this.recuos.Controls.Add(this.lb01full);
            this.recuos.Controls.Add(this.lblFonte);
            this.recuos.Location = new System.Drawing.Point(4, 24);
            this.recuos.Name = "recuos";
            this.recuos.Padding = new System.Windows.Forms.Padding(3);
            this.recuos.Size = new System.Drawing.Size(488, 331);
            this.recuos.TabIndex = 0;
            this.recuos.Text = "Fonte";
            this.recuos.UseVisualStyleBackColor = true;
            // 
            // quebras
            // 
            this.quebras.Location = new System.Drawing.Point(4, 24);
            this.quebras.Name = "quebras";
            this.quebras.Padding = new System.Windows.Forms.Padding(3);
            this.quebras.Size = new System.Drawing.Size(552, 497);
            this.quebras.TabIndex = 1;
            this.quebras.Text = "Avançado";
            this.quebras.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(419, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(324, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 26);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnPattern
            // 
            this.btnPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPattern.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPattern.Location = new System.Drawing.Point(12, 378);
            this.btnPattern.Name = "btnPattern";
            this.btnPattern.Size = new System.Drawing.Size(126, 26);
            this.btnPattern.TabIndex = 2;
            this.btnPattern.Text = "Definir como Padrão";
            this.btnPattern.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPattern.UseVisualStyleBackColor = true;
            this.btnPattern.Click += new System.EventHandler(this.btnPattern_Click);
            // 
            // btnEffects
            // 
            this.btnEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEffects.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffects.Location = new System.Drawing.Point(144, 378);
            this.btnEffects.Name = "btnEffects";
            this.btnEffects.Size = new System.Drawing.Size(104, 26);
            this.btnEffects.TabIndex = 3;
            this.btnEffects.Text = "Efeitos do Texto";
            this.btnEffects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffects.UseVisualStyleBackColor = true;
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFonte.Location = new System.Drawing.Point(21, 29);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(40, 15);
            this.lblFonte.TabIndex = 2;
            this.lblFonte.Text = "&Fonte:";
            // 
            // lb01full
            // 
            this.lb01full.FormattingEnabled = true;
            this.lb01full.ItemHeight = 15;
            this.lb01full.Items.AddRange(new object[] {
            "+ Corpo",
            "+ Títulos",
            "Abadi",
            "Abadi Extra Light",
            "Adobe Devanagari",
            "texto",
            "texto",
            "texto",
            "texto",
            "texto",
            "texto",
            "texto",
            "texto",
            "texto"});
            this.lb01full.Location = new System.Drawing.Point(24, 71);
            this.lb01full.Name = "lb01full";
            this.lb01full.Size = new System.Drawing.Size(191, 79);
            this.lb01full.TabIndex = 4;
            // 
            // lb01
            // 
            this.lb01.FormattingEnabled = true;
            this.lb01.ItemHeight = 15;
            this.lb01.Items.AddRange(new object[] {
            "+ Corpo"});
            this.lb01.Location = new System.Drawing.Point(24, 50);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(191, 19);
            this.lb01.TabIndex = 5;
            // 
            // lb02
            // 
            this.lb02.FormattingEnabled = true;
            this.lb02.ItemHeight = 15;
            this.lb02.Items.AddRange(new object[] {
            "Regular"});
            this.lb02.Location = new System.Drawing.Point(221, 50);
            this.lb02.Name = "lb02";
            this.lb02.Size = new System.Drawing.Size(146, 19);
            this.lb02.TabIndex = 8;
            // 
            // lb02full
            // 
            this.lb02full.FormattingEnabled = true;
            this.lb02full.ItemHeight = 15;
            this.lb02full.Items.AddRange(new object[] {
            "Regular",
            "Itálico",
            "Negrito",
            "Negrito Itálico"});
            this.lb02full.Location = new System.Drawing.Point(221, 71);
            this.lb02full.Name = "lb02full";
            this.lb02full.Size = new System.Drawing.Size(146, 79);
            this.lb02full.TabIndex = 7;
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontStyle.Location = new System.Drawing.Point(218, 29);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(85, 15);
            this.lblFontStyle.TabIndex = 6;
            this.lblFontStyle.Text = "Estil&o da fonte:";
            // 
            // lb03
            // 
            this.lb03.FormattingEnabled = true;
            this.lb03.ItemHeight = 15;
            this.lb03.Items.AddRange(new object[] {
            "11"});
            this.lb03.Location = new System.Drawing.Point(373, 50);
            this.lb03.Name = "lb03";
            this.lb03.Size = new System.Drawing.Size(92, 19);
            this.lb03.TabIndex = 11;
            // 
            // lb03full
            // 
            this.lb03full.FormattingEnabled = true;
            this.lb03full.ItemHeight = 15;
            this.lb03full.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lb03full.Location = new System.Drawing.Point(373, 71);
            this.lb03full.Name = "lb03full";
            this.lb03full.Size = new System.Drawing.Size(92, 79);
            this.lb03full.TabIndex = 10;
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(370, 29);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(60, 15);
            this.lblFontSize.TabIndex = 9;
            this.lblFontSize.Text = "T&amanho:";
            // 
            // lblFontColor
            // 
            this.lblFontColor.AutoSize = true;
            this.lblFontColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontColor.Location = new System.Drawing.Point(21, 161);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(75, 15);
            this.lblFontColor.TabIndex = 12;
            this.lblFontColor.Text = "Cor da font&e:";
            // 
            // cbFontColor
            // 
            this.cbFontColor.FormattingEnabled = true;
            this.cbFontColor.Items.AddRange(new object[] {
            "Automático",
            "Escolher"});
            this.cbFontColor.Location = new System.Drawing.Point(24, 179);
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbFontColor.Size = new System.Drawing.Size(121, 23);
            this.cbFontColor.TabIndex = 13;
            this.cbFontColor.Text = "Automático";
            // 
            // cbUnderStyle
            // 
            this.cbUnderStyle.FormattingEnabled = true;
            this.cbUnderStyle.Items.AddRange(new object[] {
            "Automático",
            "Escolher"});
            this.cbUnderStyle.Location = new System.Drawing.Point(151, 179);
            this.cbUnderStyle.Name = "cbUnderStyle";
            this.cbUnderStyle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUnderStyle.Size = new System.Drawing.Size(152, 23);
            this.cbUnderStyle.TabIndex = 15;
            this.cbUnderStyle.Text = "(nenhum)";
            // 
            // lblUnderline
            // 
            this.lblUnderline.AutoSize = true;
            this.lblUnderline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline.Location = new System.Drawing.Point(148, 161);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(116, 15);
            this.lblUnderline.TabIndex = 14;
            this.lblUnderline.Text = "Est&ilo de sublinhado:";
            // 
            // cbUnderColor
            // 
            this.cbUnderColor.Enabled = false;
            this.cbUnderColor.FormattingEnabled = true;
            this.cbUnderColor.Items.AddRange(new object[] {
            "Automático",
            "Escolher"});
            this.cbUnderColor.Location = new System.Drawing.Point(309, 179);
            this.cbUnderColor.Name = "cbUnderColor";
            this.cbUnderColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUnderColor.Size = new System.Drawing.Size(156, 23);
            this.cbUnderColor.TabIndex = 17;
            this.cbUnderColor.Text = "Automático";
            this.cbUnderColor.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblUnderColor
            // 
            this.lblUnderColor.AutoSize = true;
            this.lblUnderColor.Enabled = false;
            this.lblUnderColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderColor.Location = new System.Drawing.Point(306, 161);
            this.lblUnderColor.Name = "lblUnderColor";
            this.lblUnderColor.Size = new System.Drawing.Size(107, 15);
            this.lblUnderColor.TabIndex = 16;
            this.lblUnderColor.Text = "Cor do sublinhado:";
            this.lblUnderColor.Click += new System.EventHandler(this.label5_Click);
            // 
            // gbEffects
            // 
            this.gbEffects.Controls.Add(this.checkedListBox2);
            this.gbEffects.Controls.Add(this.checkedListBox1);
            this.gbEffects.Location = new System.Drawing.Point(8, 214);
            this.gbEffects.Name = "gbEffects";
            this.gbEffects.Size = new System.Drawing.Size(466, 107);
            this.gbEffects.TabIndex = 18;
            this.gbEffects.TabStop = false;
            this.gbEffects.Text = "Efeitos";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tachado",
            "Tachado duplo",
            "Sobrescrito",
            "Subscrito"});
            this.checkedListBox1.Location = new System.Drawing.Point(19, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 72);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Versalete",
            "Todas em maiúsculas",
            "Oculto"});
            this.checkedListBox2.Location = new System.Drawing.Point(307, 22);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(140, 72);
            this.checkedListBox2.TabIndex = 1;
            // 
            // fonte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.btnEffects);
            this.Controls.Add(this.btnPattern);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "fonte";
            this.ShowIcon = false;
            this.Text = "Fonte";
            this.tabControl1.ResumeLayout(false);
            this.recuos.ResumeLayout(false);
            this.recuos.PerformLayout();
            this.gbEffects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage recuos;
        private System.Windows.Forms.TabPage quebras;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnPattern;
        private System.Windows.Forms.Button btnEffects;
        private System.Windows.Forms.ListBox lb03;
        private System.Windows.Forms.ListBox lb03full;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ListBox lb02;
        private System.Windows.Forms.ListBox lb02full;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.ListBox lb01;
        private System.Windows.Forms.ListBox lb01full;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.ComboBox cbUnderColor;
        private System.Windows.Forms.Label lblUnderColor;
        private System.Windows.Forms.ComboBox cbUnderStyle;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.GroupBox gbEffects;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        internal System.Windows.Forms.ComboBox cbFontColor;
    }
}

