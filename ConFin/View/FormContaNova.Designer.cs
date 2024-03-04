namespace ConFin.View
{
    partial class FormContaNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaNova));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(34, 55);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(334, 22);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(401, 55);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(118, 22);
            this.textBoxValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Vencimento";
            // 
            // maskedTextBoxDataVencimento
            // 
            this.maskedTextBoxDataVencimento.Location = new System.Drawing.Point(34, 145);
            this.maskedTextBoxDataVencimento.Mask = "00/00/0000";
            this.maskedTextBoxDataVencimento.Name = "maskedTextBoxDataVencimento";
            this.maskedTextBoxDataVencimento.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxDataVencimento.TabIndex = 5;
            this.maskedTextBoxDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataPagamento
            // 
            this.maskedTextBoxDataPagamento.Location = new System.Drawing.Point(241, 145);
            this.maskedTextBoxDataPagamento.Mask = "00/00/0000";
            this.maskedTextBoxDataPagamento.Name = "maskedTextBoxDataPagamento";
            this.maskedTextBoxDataPagamento.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxDataPagamento.TabIndex = 7;
            this.maskedTextBoxDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Pagamento";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "À Pagar",
            "À Receber"});
            this.comboBoxTipo.Location = new System.Drawing.Point(442, 143);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Situacao";
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Aberta",
            "Paga"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(585, 143);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSituacao.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pessoa";
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Location = new System.Drawing.Point(34, 223);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(529, 24);
            this.comboBoxPessoa.TabIndex = 12;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(215, 301);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(126, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar Conta";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(374, 301);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(126, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormContaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 376);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPessoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.maskedTextBoxDataPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxDataVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataVencimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPessoa;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}