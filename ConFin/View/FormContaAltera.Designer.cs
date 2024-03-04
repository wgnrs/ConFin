namespace ConFin.View
{
    partial class FormContaAltera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaAltera));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(373, 357);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(126, 23);
            this.buttonCancelar.TabIndex = 31;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(214, 357);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(126, 23);
            this.buttonSalvar.TabIndex = 30;
            this.buttonSalvar.Text = "Salvar Conta";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pessoa";
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Location = new System.Drawing.Point(33, 284);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(529, 24);
            this.comboBoxPessoa.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Situacao";
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Aberta",
            "Paga"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(584, 204);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSituacao.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "À Pagar",
            "À Receber"});
            this.comboBoxTipo.Location = new System.Drawing.Point(441, 204);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 24;
            // 
            // maskedTextBoxDataPagamento
            // 
            this.maskedTextBoxDataPagamento.Location = new System.Drawing.Point(240, 206);
            this.maskedTextBoxDataPagamento.Mask = "00/00/0000";
            this.maskedTextBoxDataPagamento.Name = "maskedTextBoxDataPagamento";
            this.maskedTextBoxDataPagamento.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxDataPagamento.TabIndex = 23;
            this.maskedTextBoxDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data de Pagamento";
            // 
            // maskedTextBoxDataVencimento
            // 
            this.maskedTextBoxDataVencimento.Location = new System.Drawing.Point(33, 206);
            this.maskedTextBoxDataVencimento.Mask = "00/00/0000";
            this.maskedTextBoxDataVencimento.Name = "maskedTextBoxDataVencimento";
            this.maskedTextBoxDataVencimento.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxDataVencimento.TabIndex = 21;
            this.maskedTextBoxDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Vencimento";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(400, 116);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(118, 22);
            this.textBoxValor.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(33, 116);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(334, 22);
            this.textBoxDescricao.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descrição";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(33, 42);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(89, 22);
            this.textBoxId.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Id";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FormContaAltera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 402);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label8);
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
            this.Name = "FormContaAltera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPessoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label8;
    }
}