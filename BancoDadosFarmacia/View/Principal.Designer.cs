namespace View
{
    partial class Principal
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
            this.btnComestivel = new System.Windows.Forms.Button();
            this.btnHigienicos = new System.Windows.Forms.Button();
            this.btnRemedios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComestivel
            // 
            this.btnComestivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComestivel.Location = new System.Drawing.Point(12, 12);
            this.btnComestivel.Name = "btnComestivel";
            this.btnComestivel.Size = new System.Drawing.Size(251, 261);
            this.btnComestivel.TabIndex = 14;
            this.btnComestivel.Text = " Comestiveis";
            this.btnComestivel.UseVisualStyleBackColor = true;
            this.btnComestivel.Click += new System.EventHandler(this.btnComestivel_Click);
            // 
            // btnHigienicos
            // 
            this.btnHigienicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigienicos.Location = new System.Drawing.Point(269, 12);
            this.btnHigienicos.Name = "btnHigienicos";
            this.btnHigienicos.Size = new System.Drawing.Size(252, 261);
            this.btnHigienicos.TabIndex = 15;
            this.btnHigienicos.Text = "Produtos Higienicos";
            this.btnHigienicos.UseVisualStyleBackColor = true;
            this.btnHigienicos.Click += new System.EventHandler(this.btnHigienicos_Click);
            // 
            // btnRemedios
            // 
            this.btnRemedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemedios.Location = new System.Drawing.Point(527, 12);
            this.btnRemedios.Name = "btnRemedios";
            this.btnRemedios.Size = new System.Drawing.Size(243, 261);
            this.btnRemedios.TabIndex = 16;
            this.btnRemedios.Text = "Remédios";
            this.btnRemedios.UseVisualStyleBackColor = true;
            this.btnRemedios.Click += new System.EventHandler(this.btnRemedios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 288);
            this.Controls.Add(this.btnRemedios);
            this.Controls.Add(this.btnHigienicos);
            this.Controls.Add(this.btnComestivel);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComestivel;
        private System.Windows.Forms.Button btnHigienicos;
        private System.Windows.Forms.Button btnRemedios;
    }
}