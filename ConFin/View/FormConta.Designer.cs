namespace ConFin.View
{
    partial class FormConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConta));
            this.dataGridViewMostra = new System.Windows.Forms.DataGridView();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonAltera = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.contaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostra
            // 
            this.dataGridViewMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contaId,
            this.descricao,
            this.valor,
            this.tipo,
            this.situacao,
            this.datavencimento,
            this.datapagamento,
            this.pessoaId});
            this.dataGridViewMostra.Location = new System.Drawing.Point(28, 45);
            this.dataGridViewMostra.Name = "dataGridViewMostra";
            this.dataGridViewMostra.RowHeadersWidth = 51;
            this.dataGridViewMostra.RowTemplate.Height = 24;
            this.dataGridViewMostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostra.Size = new System.Drawing.Size(625, 270);
            this.dataGridViewMostra.TabIndex = 0;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(130, 371);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(101, 23);
            this.buttonNovo.TabIndex = 1;
            this.buttonNovo.Text = "Salvar Conta";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonAltera
            // 
            this.buttonAltera.Location = new System.Drawing.Point(296, 371);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(101, 23);
            this.buttonAltera.TabIndex = 2;
            this.buttonAltera.Text = "Alterar Conta";
            this.buttonAltera.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(460, 371);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(101, 23);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir Conta";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // contaId
            // 
            this.contaId.DataPropertyName = "contaId";
            this.contaId.HeaderText = "Id";
            this.contaId.MinimumWidth = 6;
            this.contaId.Name = "contaId";
            this.contaId.Width = 40;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.Width = 125;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.Width = 125;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.Width = 60;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.MinimumWidth = 6;
            this.situacao.Name = "situacao";
            this.situacao.Width = 60;
            // 
            // datavencimento
            // 
            this.datavencimento.DataPropertyName = "datavencimento";
            this.datavencimento.HeaderText = "Data de Vencimento";
            this.datavencimento.MinimumWidth = 6;
            this.datavencimento.Name = "datavencimento";
            this.datavencimento.Width = 125;
            // 
            // datapagamento
            // 
            this.datapagamento.DataPropertyName = "datapagamento";
            this.datapagamento.HeaderText = "Data de Pagamento";
            this.datapagamento.MinimumWidth = 6;
            this.datapagamento.Name = "datapagamento";
            this.datapagamento.Width = 125;
            // 
            // pessoaId
            // 
            this.pessoaId.DataPropertyName = "pessoaId";
            this.pessoaId.HeaderText = "Id Pessoa";
            this.pessoaId.MinimumWidth = 6;
            this.pessoaId.Name = "pessoaId";
            this.pessoaId.Width = 75;
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAltera);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.dataGridViewMostra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Conta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostra;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAltera;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaId;
    }
}