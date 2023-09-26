
namespace Calculadora_Windows3._0_Login_Version0._1_
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.CaixaSenha = new System.Windows.Forms.TextBox();
            this.CaixaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotaoCancelar);
            this.groupBox1.Controls.Add(this.BotaoEntrar);
            this.groupBox1.Controls.Add(this.CaixaSenha);
            this.groupBox1.Controls.Add(this.CaixaUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "logue aí, queride!";
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoCancelar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotaoCancelar.Location = new System.Drawing.Point(452, 285);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(98, 29);
            this.BotaoCancelar.TabIndex = 5;
            this.BotaoCancelar.Text = "cancele";
            this.BotaoCancelar.UseVisualStyleBackColor = false;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.BackColor = System.Drawing.Color.White;
            this.BotaoEntrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotaoEntrar.Location = new System.Drawing.Point(334, 285);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(98, 29);
            this.BotaoEntrar.TabIndex = 4;
            this.BotaoEntrar.Text = "entre";
            this.BotaoEntrar.UseVisualStyleBackColor = false;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // CaixaSenha
            // 
            this.CaixaSenha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaSenha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CaixaSenha.Location = new System.Drawing.Point(111, 234);
            this.CaixaSenha.Multiline = true;
            this.CaixaSenha.Name = "CaixaSenha";
            this.CaixaSenha.PasswordChar = '*';
            this.CaixaSenha.ShortcutsEnabled = false;
            this.CaixaSenha.Size = new System.Drawing.Size(208, 34);
            this.CaixaSenha.TabIndex = 3;
            this.CaixaSenha.TabStop = false;
            this.CaixaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaixaSenha.UseWaitCursor = true;
            this.CaixaSenha.TextChanged += new System.EventHandler(this.CaixaSenha_TextChanged);
            // 
            // CaixaUsuario
            // 
            this.CaixaUsuario.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.CaixaUsuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaixaUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CaixaUsuario.Location = new System.Drawing.Point(111, 121);
            this.CaixaUsuario.Multiline = true;
            this.CaixaUsuario.Name = "CaixaUsuario";
            this.CaixaUsuario.Size = new System.Drawing.Size(208, 30);
            this.CaixaUsuario.TabIndex = 2;
            this.CaixaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaixaUsuario.TextChanged += new System.EventHandler(this.CaixaUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "senhazinha";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(107, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuáre";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.TextBox CaixaSenha;
        private System.Windows.Forms.TextBox CaixaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

