﻿namespace View
{
    partial class EditarRemedios
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
            this.lblPrecisaReceita = new System.Windows.Forms.Label();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.cbxFaixa = new System.Windows.Forms.ComboBox();
            this.txtBula = new System.Windows.Forms.TextBox();
            this.lblBula = new System.Windows.Forms.Label();
            this.txtContraIndicacoes = new System.Windows.Forms.TextBox();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.lblSolido = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(228, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(190, 192);
            this.btnSalvar.TabIndex = 60;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cbPrecisaReceita
            // 
            this.cbPrecisaReceita.AutoSize = true;
            this.cbPrecisaReceita.Location = new System.Drawing.Point(228, 62);
            this.cbPrecisaReceita.Name = "cbPrecisaReceita";
            this.cbPrecisaReceita.Size = new System.Drawing.Size(15, 14);
            this.cbPrecisaReceita.TabIndex = 59;
            this.cbPrecisaReceita.UseVisualStyleBackColor = true;
            // 
            // cbSolido
            // 
            this.cbSolido.AutoSize = true;
            this.cbSolido.Location = new System.Drawing.Point(12, 222);
            this.cbSolido.Name = "cbSolido";
            this.cbSolido.Size = new System.Drawing.Size(15, 14);
            this.cbSolido.TabIndex = 58;
            this.cbSolido.UseVisualStyleBackColor = true;
            // 
            // cbGenerico
            // 
            this.cbGenerico.AutoSize = true;
            this.cbGenerico.Location = new System.Drawing.Point(12, 60);
            this.cbGenerico.Name = "cbGenerico";
            this.cbGenerico.Size = new System.Drawing.Size(15, 14);
            this.cbGenerico.TabIndex = 57;
            this.cbGenerico.UseVisualStyleBackColor = true;
            // 
            // lblPrecisaReceita
            // 
            this.lblPrecisaReceita.AutoSize = true;
            this.lblPrecisaReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecisaReceita.Location = new System.Drawing.Point(249, 60);
            this.lblPrecisaReceita.Name = "lblPrecisaReceita";
            this.lblPrecisaReceita.Size = new System.Drawing.Size(119, 16);
            this.lblPrecisaReceita.TabIndex = 56;
            this.lblPrecisaReceita.Text = "Precisa Receita";
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(225, 98);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(46, 16);
            this.lblFaixa.TabIndex = 55;
            this.lblFaixa.Text = "Faixa";
            // 
            // cbxFaixa
            // 
            this.cbxFaixa.FormattingEnabled = true;
            this.cbxFaixa.Items.AddRange(new object[] {
            "Preta",
            "Vermelha",
            "Amarela",
            "Branca"});
            this.cbxFaixa.Location = new System.Drawing.Point(228, 116);
            this.cbxFaixa.Name = "cbxFaixa";
            this.cbxFaixa.Size = new System.Drawing.Size(190, 21);
            this.cbxFaixa.TabIndex = 54;
            // 
            // txtBula
            // 
            this.txtBula.Location = new System.Drawing.Point(12, 334);
            this.txtBula.Name = "txtBula";
            this.txtBula.Size = new System.Drawing.Size(186, 20);
            this.txtBula.TabIndex = 53;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBula.Location = new System.Drawing.Point(9, 315);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(39, 16);
            this.lblBula.TabIndex = 52;
            this.lblBula.Text = "Bula";
            // 
            // txtContraIndicacoes
            // 
            this.txtContraIndicacoes.Location = new System.Drawing.Point(12, 275);
            this.txtContraIndicacoes.Name = "txtContraIndicacoes";
            this.txtContraIndicacoes.Size = new System.Drawing.Size(186, 20);
            this.txtContraIndicacoes.TabIndex = 51;
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacoes.Location = new System.Drawing.Point(9, 256);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(133, 16);
            this.lblContraIndicacoes.TabIndex = 50;
            this.lblContraIndicacoes.Text = "Contra Indicações";
            // 
            // lblSolido
            // 
            this.lblSolido.AutoSize = true;
            this.lblSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolido.Location = new System.Drawing.Point(32, 222);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(53, 16);
            this.lblSolido.TabIndex = 49;
            this.lblSolido.Text = "Sólido";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(9, 162);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 16);
            this.lblCategoria.TabIndex = 48;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(12, 181);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(186, 21);
            this.cbxCategoria.TabIndex = 47;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 44;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 43;
            this.lblNome.Text = "Nome";
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerico.Location = new System.Drawing.Point(33, 60);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(71, 16);
            this.lblGenerico.TabIndex = 42;
            this.lblGenerico.Text = "Genérico";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(77, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 16);
            this.lblId.TabIndex = 62;
            this.lblId.Text = "0";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 16);
            this.lblCodigo.TabIndex = 61;
            this.lblCodigo.Text = "Código:";
            // 
            // EditarRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 358);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbPrecisaReceita);
            this.Controls.Add(this.cbSolido);
            this.Controls.Add(this.cbGenerico);
            this.Controls.Add(this.lblPrecisaReceita);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.cbxFaixa);
            this.Controls.Add(this.txtBula);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.txtContraIndicacoes);
            this.Controls.Add(this.lblContraIndicacoes);
            this.Controls.Add(this.lblSolido);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblGenerico);
            this.Name = "EditarRemedios";
            this.Text = "EditarRemedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox cbPrecisaReceita;
        private System.Windows.Forms.CheckBox cbSolido;
        private System.Windows.Forms.CheckBox cbGenerico;
        private System.Windows.Forms.Label lblPrecisaReceita;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.ComboBox cbxFaixa;
        private System.Windows.Forms.TextBox txtBula;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.TextBox txtContraIndicacoes;
        private System.Windows.Forms.Label lblContraIndicacoes;
        private System.Windows.Forms.Label lblSolido;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCodigo;
    }
}