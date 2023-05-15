namespace prjSalarioSituação
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcula = new System.Windows.Forms.Button();
            this.ckValeTransporte = new System.Windows.Forms.CheckBox();
            this.ckConvenio = new System.Windows.Forms.CheckBox();
            this.lblSalDigit = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(268, 181);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(73, 30);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // ckValeTransporte
            // 
            this.ckValeTransporte.AutoSize = true;
            this.ckValeTransporte.Location = new System.Drawing.Point(95, 126);
            this.ckValeTransporte.Name = "ckValeTransporte";
            this.ckValeTransporte.Size = new System.Drawing.Size(147, 19);
            this.ckValeTransporte.TabIndex = 1;
            this.ckValeTransporte.Text = "Recebo Vale Transporte";
            this.ckValeTransporte.UseVisualStyleBackColor = true;
            // 
            // ckConvenio
            // 
            this.ckConvenio.AutoSize = true;
            this.ckConvenio.Location = new System.Drawing.Point(367, 126);
            this.ckConvenio.Name = "ckConvenio";
            this.ckConvenio.Size = new System.Drawing.Size(162, 19);
            this.ckConvenio.TabIndex = 2;
            this.ckConvenio.Text = "Recebo Convênio Médico";
            this.ckConvenio.UseVisualStyleBackColor = true;
            // 
            // lblSalDigit
            // 
            this.lblSalDigit.AutoSize = true;
            this.lblSalDigit.Location = new System.Drawing.Point(98, 38);
            this.lblSalDigit.Name = "lblSalDigit";
            this.lblSalDigit.Size = new System.Drawing.Size(144, 15);
            this.lblSalDigit.TabIndex = 3;
            this.lblSalDigit.Text = "Digite o salário Bruto (R$):";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(133, 355);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(112, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Salário Líquido (R$):";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(255, 38);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 23);
            this.txtSalBruto.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(255, 355);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 23);
            this.txtResult.TabIndex = 6;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(243, 148);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 15);
            this.lblSituacao.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSalDigit);
            this.Controls.Add(this.ckConvenio);
            this.Controls.Add(this.ckValeTransporte);
            this.Controls.Add(this.btnCalcula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcula;
        private CheckBox ckValeTransporte;
        private CheckBox ckConvenio;
        private Label lblSalDigit;
        private Label lblResultado;
        private TextBox txtSalBruto;
        private TextBox txtResult;
        private Label lblSituacao;
    }
}