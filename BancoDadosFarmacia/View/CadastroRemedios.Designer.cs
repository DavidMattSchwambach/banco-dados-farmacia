namespace View
{
    partial class CadastroRemedios
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbPrecisaReceita = new System.Windows.Forms.CheckBox();
            this.cbSolido = new System.Windows.Forms.CheckBox();
            this.cbGenerico = new System.Windows.Forms.CheckBox();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.cbxFaixa = new System.Windows.Forms.ComboBox();
            this.txtBula = new System.Windows.Forms.TextBox();
            this.lblBula = new System.Windows.Forms.Label();
            this.txtContraIndicacoes = new System.Windows.Forms.TextBox();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(227, 179);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(190, 73);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbPrecisaReceita
            // 
            this.cbPrecisaReceita.AutoSize = true;
            this.cbPrecisaReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrecisaReceita.Location = new System.Drawing.Point(227, 19);
            this.cbPrecisaReceita.Name = "cbPrecisaReceita";
            this.cbPrecisaReceita.Size = new System.Drawing.Size(138, 20);
            this.cbPrecisaReceita.TabIndex = 40;
            this.cbPrecisaReceita.Text = "Precisa Receita";
            this.cbPrecisaReceita.UseVisualStyleBackColor = true;
            // 
            // cbSolido
            // 
            this.cbSolido.AutoSize = true;
            this.cbSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSolido.Location = new System.Drawing.Point(12, 179);
            this.cbSolido.Name = "cbSolido";
            this.cbSolido.Size = new System.Drawing.Size(72, 20);
            this.cbSolido.TabIndex = 39;
            this.cbSolido.Text = "Sólido";
            this.cbSolido.UseVisualStyleBackColor = true;
            // 
            // cbGenerico
            // 
            this.cbGenerico.AutoSize = true;
            this.cbGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenerico.Location = new System.Drawing.Point(12, 17);
            this.cbGenerico.Name = "cbGenerico";
            this.cbGenerico.Size = new System.Drawing.Size(90, 20);
            this.cbGenerico.TabIndex = 38;
            this.cbGenerico.Text = "Genérico";
            this.cbGenerico.UseVisualStyleBackColor = true;
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(224, 120);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(46, 16);
            this.lblFaixa.TabIndex = 36;
            this.lblFaixa.Text = "Faixa";
            // 
            // cbxFaixa
            // 
            this.cbxFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFaixa.FormattingEnabled = true;
            this.cbxFaixa.Items.AddRange(new object[] {
            "Preta",
            "Vermelha",
            "Amarela",
            "Branca"});
            this.cbxFaixa.Location = new System.Drawing.Point(227, 138);
            this.cbxFaixa.Name = "cbxFaixa";
            this.cbxFaixa.Size = new System.Drawing.Size(190, 21);
            this.cbxFaixa.TabIndex = 5;
            // 
            // txtBula
            // 
            this.txtBula.Location = new System.Drawing.Point(227, 74);
            this.txtBula.Name = "txtBula";
            this.txtBula.Size = new System.Drawing.Size(186, 20);
            this.txtBula.TabIndex = 4;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBula.Location = new System.Drawing.Point(224, 55);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(39, 16);
            this.lblBula.TabIndex = 33;
            this.lblBula.Text = "Bula";
            // 
            // txtContraIndicacoes
            // 
            this.txtContraIndicacoes.Location = new System.Drawing.Point(12, 232);
            this.txtContraIndicacoes.Name = "txtContraIndicacoes";
            this.txtContraIndicacoes.Size = new System.Drawing.Size(186, 20);
            this.txtContraIndicacoes.TabIndex = 3;
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacoes.Location = new System.Drawing.Point(9, 213);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(133, 16);
            this.lblContraIndicacoes.TabIndex = 31;
            this.lblContraIndicacoes.Text = "Contra Indicações";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 16);
            this.lblCategoria.TabIndex = 29;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Analgésico",
            "Anfetamina",
            "Antiácido",
            "Antibiótico",
            "Antídoto",
            "Aspirina",
            "Barbitúrico"});
            this.cbxCategoria.Location = new System.Drawing.Point(12, 138);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(186, 21);
            this.cbxCategoria.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // CadastroRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbPrecisaReceita);
            this.Controls.Add(this.cbSolido);
            this.Controls.Add(this.cbGenerico);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.cbxFaixa);
            this.Controls.Add(this.txtBula);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.txtContraIndicacoes);
            this.Controls.Add(this.lblContraIndicacoes);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroRemedios";
            this.Text = "CadastroRemedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox cbPrecisaReceita;
        private System.Windows.Forms.CheckBox cbSolido;
        private System.Windows.Forms.CheckBox cbGenerico;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.ComboBox cbxFaixa;
        private System.Windows.Forms.TextBox txtBula;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.TextBox txtContraIndicacoes;
        private System.Windows.Forms.Label lblContraIndicacoes;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}