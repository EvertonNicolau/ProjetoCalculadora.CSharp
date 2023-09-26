
namespace Calculadora_Windows3._0_Login_Version0._1_
{
    partial class CalculadoraRadio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BotaoCalcular = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.RadioButton();
            this.Multiplicacao = new System.Windows.Forms.RadioButton();
            this.Subtracao = new System.Windows.Forms.RadioButton();
            this.Soma = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Operacao = new System.Windows.Forms.Label();
            this.Caixa2 = new System.Windows.Forms.TextBox();
            this.Caixa1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.BotaoVoltar);
            this.groupBox1.Controls.Add(this.BotaoLimpar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Operacao);
            this.groupBox1.Controls.Add(this.Caixa2);
            this.groupBox1.Controls.Add(this.Caixa1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora Radio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotaoCalcular);
            this.groupBox2.Controls.Add(this.Divisao);
            this.groupBox2.Controls.Add(this.Multiplicacao);
            this.groupBox2.Controls.Add(this.Subtracao);
            this.groupBox2.Controls.Add(this.Soma);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(21, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores";
            // 
            // BotaoCalcular
            // 
            this.BotaoCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoCalcular.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotaoCalcular.Location = new System.Drawing.Point(256, 97);
            this.BotaoCalcular.Name = "BotaoCalcular";
            this.BotaoCalcular.Size = new System.Drawing.Size(148, 43);
            this.BotaoCalcular.TabIndex = 4;
            this.BotaoCalcular.Text = "Calcular";
            this.BotaoCalcular.UseVisualStyleBackColor = false;
            this.BotaoCalcular.Click += new System.EventHandler(this.BotaoCalcular_Click);
            // 
            // Divisao
            // 
            this.Divisao.AutoSize = true;
            this.Divisao.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.Location = new System.Drawing.Point(555, 45);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(99, 29);
            this.Divisao.TabIndex = 3;
            this.Divisao.TabStop = true;
            this.Divisao.Text = "Divisão";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.CheckedChanged += new System.EventHandler(this.Divisao_CheckedChanged);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.AutoSize = true;
            this.Multiplicacao.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacao.Location = new System.Drawing.Point(346, 45);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(157, 29);
            this.Multiplicacao.TabIndex = 2;
            this.Multiplicacao.TabStop = true;
            this.Multiplicacao.Text = "Multiplicação";
            this.Multiplicacao.UseVisualStyleBackColor = true;
            this.Multiplicacao.CheckedChanged += new System.EventHandler(this.Multiplicacao_CheckedChanged);
            // 
            // Subtracao
            // 
            this.Subtracao.AutoSize = true;
            this.Subtracao.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtracao.Location = new System.Drawing.Point(160, 45);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(125, 29);
            this.Subtracao.TabIndex = 1;
            this.Subtracao.TabStop = true;
            this.Subtracao.Text = "Subtração";
            this.Subtracao.UseVisualStyleBackColor = true;
            this.Subtracao.CheckedChanged += new System.EventHandler(this.Subtracao_CheckedChanged);
            // 
            // Soma
            // 
            this.Soma.AutoSize = true;
            this.Soma.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.Location = new System.Drawing.Point(27, 45);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(83, 29);
            this.Soma.TabIndex = 0;
            this.Soma.TabStop = true;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.CheckedChanged += new System.EventHandler(this.Soma_CheckedChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(495, 76);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(31, 31);
            this.Result.TabIndex = 4;
            this.Result.Text = "_";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Operacao
            // 
            this.Operacao.AutoSize = true;
            this.Operacao.Location = new System.Drawing.Point(259, 79);
            this.Operacao.Name = "Operacao";
            this.Operacao.Size = new System.Drawing.Size(27, 31);
            this.Operacao.TabIndex = 2;
            this.Operacao.Text = "?";
            this.Operacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Operacao.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // Caixa2
            // 
            this.Caixa2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Caixa2.Location = new System.Drawing.Point(306, 76);
            this.Caixa2.Multiline = true;
            this.Caixa2.Name = "Caixa2";
            this.Caixa2.Size = new System.Drawing.Size(119, 31);
            this.Caixa2.TabIndex = 1;
            this.Caixa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Caixa2.TextChanged += new System.EventHandler(this.Caixa2_TextChanged);
            // 
            // Caixa1
            // 
            this.Caixa1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Caixa1.Location = new System.Drawing.Point(107, 76);
            this.Caixa1.Multiline = true;
            this.Caixa1.Name = "Caixa1";
            this.Caixa1.Size = new System.Drawing.Size(120, 31);
            this.Caixa1.TabIndex = 0;
            this.Caixa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Caixa1.TextChanged += new System.EventHandler(this.Caixa1_TextChanged);
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoVoltar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotaoVoltar.Location = new System.Drawing.Point(626, 327);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 32);
            this.BotaoVoltar.TabIndex = 1;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = false;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoLimpar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotaoLimpar.Location = new System.Drawing.Point(541, 327);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(75, 32);
            this.BotaoLimpar.TabIndex = 2;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = false;
            this.BotaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // CalculadoraRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculadoraRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Radio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Divisao;
        private System.Windows.Forms.RadioButton Multiplicacao;
        private System.Windows.Forms.RadioButton Subtracao;
        private System.Windows.Forms.RadioButton Soma;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Operacao;
        private System.Windows.Forms.TextBox Caixa2;
        private System.Windows.Forms.TextBox Caixa1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BotaoVoltar;
        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.Button BotaoCalcular;
    }
}