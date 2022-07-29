namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbxDadosEntrega = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lvlValor = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValoresCalc = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDadosEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(79, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(154, 20);
            this.txtValor.TabIndex = 1;
            // 
            // gbxDadosEntrega
            // 
            this.gbxDadosEntrega.Controls.Add(this.label3);
            this.gbxDadosEntrega.Controls.Add(this.label2);
            this.gbxDadosEntrega.Controls.Add(this.label1);
            this.gbxDadosEntrega.Controls.Add(this.lblTotal);
            this.gbxDadosEntrega.Controls.Add(this.lblFrete);
            this.gbxDadosEntrega.Controls.Add(this.lblValorCompra);
            this.gbxDadosEntrega.Controls.Add(this.lblValoresCalc);
            this.gbxDadosEntrega.Controls.Add(this.btnLimpar);
            this.gbxDadosEntrega.Controls.Add(this.btnCalcular);
            this.gbxDadosEntrega.Controls.Add(this.cbxUF);
            this.gbxDadosEntrega.Controls.Add(this.lblUF);
            this.gbxDadosEntrega.Controls.Add(this.txtValor);
            this.gbxDadosEntrega.Controls.Add(this.lvlValor);
            this.gbxDadosEntrega.Controls.Add(this.txtNome);
            this.gbxDadosEntrega.Controls.Add(this.lblNome);
            this.gbxDadosEntrega.Location = new System.Drawing.Point(32, 26);
            this.gbxDadosEntrega.Name = "gbxDadosEntrega";
            this.gbxDadosEntrega.Size = new System.Drawing.Size(355, 471);
            this.gbxDadosEntrega.TabIndex = 2;
            this.gbxDadosEntrega.TabStop = false;
            this.gbxDadosEntrega.Text = "Dados da Entrega";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lvlValor
            // 
            this.lvlValor.AutoSize = true;
            this.lvlValor.Location = new System.Drawing.Point(21, 73);
            this.lvlValor.Name = "lvlValor";
            this.lvlValor.Size = new System.Drawing.Size(34, 13);
            this.lvlValor.TabIndex = 1;
            this.lvlValor.Text = "Valor:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(21, 110);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(43, 13);
            this.lblUF.TabIndex = 2;
            this.lblUF.Text = "Estado:";
            // 
            // cbxUF
            // 
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AM",
            "Outros..."});
            this.cbxUF.Location = new System.Drawing.Point(79, 110);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(154, 21);
            this.cbxUF.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 41);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(178, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 41);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValoresCalc
            // 
            this.lblValoresCalc.AutoSize = true;
            this.lblValoresCalc.Location = new System.Drawing.Point(17, 246);
            this.lblValoresCalc.Name = "lblValoresCalc";
            this.lblValoresCalc.Size = new System.Drawing.Size(100, 13);
            this.lblValoresCalc.TabIndex = 7;
            this.lblValoresCalc.Text = "Valores Calculados:";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(29, 283);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(88, 13);
            this.lblValorCompra.TabIndex = 8;
            this.lblValorCompra.Text = "Valor da Compra:";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(29, 318);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(31, 13);
            this.lblFrete.TabIndex = 9;
            this.lblFrete.Text = "Frete";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "-------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 522);
            this.Controls.Add(this.gbxDadosEntrega);
            this.Name = "Form1";
            this.Text = "Cálculo de Frete";
            this.gbxDadosEntrega.ResumeLayout(false);
            this.gbxDadosEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gbxDadosEntrega;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lvlValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblValoresCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

