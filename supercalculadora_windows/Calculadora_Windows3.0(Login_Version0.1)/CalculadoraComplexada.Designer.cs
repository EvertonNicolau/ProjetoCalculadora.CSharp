
namespace Calculadora_Windows3._0_Login_Version0._1_
{
    partial class CalculadoraComplexada
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CaixaCombo = new System.Windows.Forms.ComboBox();
            this.Caixa02 = new System.Windows.Forms.TextBox();
            this.Caixa01 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(610, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Resultado);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CaixaCombo);
            this.groupBox1.Controls.Add(this.Caixa02);
            this.groupBox1.Controls.Add(this.Caixa01);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora  Complexada";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(679, 128);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(26, 29);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // CaixaCombo
            // 
            this.CaixaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaCombo.FormattingEnabled = true;
            this.CaixaCombo.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão",
            "Potênciação",
            "Raiz"});
            this.CaixaCombo.Location = new System.Drawing.Point(203, 128);
            this.CaixaCombo.Name = "CaixaCombo";
            this.CaixaCombo.Size = new System.Drawing.Size(159, 37);
            this.CaixaCombo.TabIndex = 2;
            // 
            // Caixa02
            // 
            this.Caixa02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa02.Location = new System.Drawing.Point(403, 128);
            this.Caixa02.Multiline = true;
            this.Caixa02.Name = "Caixa02";
            this.Caixa02.Size = new System.Drawing.Size(148, 37);
            this.Caixa02.TabIndex = 1;
            this.Caixa02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Caixa01
            // 
            this.Caixa01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa01.Location = new System.Drawing.Point(20, 128);
            this.Caixa01.Multiline = true;
            this.Caixa01.Name = "Caixa01";
            this.Caixa01.Size = new System.Drawing.Size(144, 37);
            this.Caixa01.TabIndex = 0;
            this.Caixa01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculadoraComplexada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 315);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculadoraComplexada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Complexada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CaixaCombo;
        private System.Windows.Forms.TextBox Caixa02;
        private System.Windows.Forms.TextBox Caixa01;
    }
}