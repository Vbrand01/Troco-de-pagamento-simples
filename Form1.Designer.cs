namespace FormatoMoeda
{
    partial class FormatoMoeda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorAPagar = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btoCalcular = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Troco";
            // 
            // txtValorAPagar
            // 
            this.txtValorAPagar.Location = new System.Drawing.Point(12, 44);
            this.txtValorAPagar.Name = "txtValorAPagar";
            this.txtValorAPagar.Size = new System.Drawing.Size(561, 39);
            this.txtValorAPagar.TabIndex = 0;
            this.txtValorAPagar.Enter += new System.EventHandler(this.txtValoraPagar_Enter);
            this.txtValorAPagar.Leave += new System.EventHandler(this.txtValoraPagar_Leave);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(12, 121);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(561, 39);
            this.txtValorPago.TabIndex = 1;
            this.txtValorPago.Enter += new System.EventHandler(this.txtValorPago_Enter);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValoPago_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 198);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(561, 39);
            this.txtTotal.TabIndex = 4;
            // 
            // btoCalcular
            // 
            this.btoCalcular.Location = new System.Drawing.Point(591, 44);
            this.btoCalcular.Name = "btoCalcular";
            this.btoCalcular.Size = new System.Drawing.Size(115, 39);
            this.btoCalcular.TabIndex = 2;
            this.btoCalcular.Text = "Calcular";
            this.btoCalcular.UseVisualStyleBackColor = true;
            this.btoCalcular.Click += new System.EventHandler(this.btoCalcular_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(591, 121);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(115, 39);
            this.btoLimpar.TabIndex = 3;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(591, 198);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(115, 39);
            this.btoSair.TabIndex = 5;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // FormatoMoeda
            // 
            this.AcceptButton = this.btoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btoSair;
            this.ClientSize = new System.Drawing.Size(857, 282);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtValorAPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormatoMoeda";
            this.Text = "Formato Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValorAPagar;
        private TextBox txtValorPago;
        private TextBox txtTotal;
        private Button btoCalcular;
        private Button btoLimpar;
        private Button btoSair;
    }
}