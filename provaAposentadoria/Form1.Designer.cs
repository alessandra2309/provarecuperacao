namespace provaAposentadoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_dataNascimento = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.cb_profissao = new System.Windows.Forms.ComboBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.tx_DIT = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "profissao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data inicio trabalho";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_dataNascimento
            // 
            this.tx_dataNascimento.Location = new System.Drawing.Point(128, 187);
            this.tx_dataNascimento.Name = "tx_dataNascimento";
            this.tx_dataNascimento.Size = new System.Drawing.Size(100, 20);
            this.tx_dataNascimento.TabIndex = 8;
            this.tx_dataNascimento.TextChanged += new System.EventHandler(this.tx_dataNascimento_TextChanged);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(128, 66);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 20);
            this.tx_nome.TabIndex = 9;
            // 
            // cb_profissao
            // 
            this.cb_profissao.FormattingEnabled = true;
            this.cb_profissao.Items.AddRange(new object[] {
            "saúde",
            " professor",
            "agentes de segurança ",
            " demais serviços"});
            this.cb_profissao.Location = new System.Drawing.Point(394, 130);
            this.cb_profissao.Name = "cb_profissao";
            this.cb_profissao.Size = new System.Drawing.Size(90, 21);
            this.cb_profissao.TabIndex = 10;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(385, 63);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(69, 21);
            this.cb_sexo.TabIndex = 11;
            // 
            // tx_DIT
            // 
            this.tx_DIT.Location = new System.Drawing.Point(452, 190);
            this.tx_DIT.Name = "tx_DIT";
            this.tx_DIT.Size = new System.Drawing.Size(100, 20);
            this.tx_DIT.TabIndex = 12;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(128, 131);
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 20);
            this.tx_cpf.TabIndex = 13;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(70, 230);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 13);
            this.lb_result.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_DIT);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.cb_profissao);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_dataNascimento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tx_dataNascimento;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.ComboBox cb_profissao;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.TextBox tx_DIT;
        private System.Windows.Forms.TextBox tx_cpf;
        private System.Windows.Forms.Label lb_result;
    }
}

