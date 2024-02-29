namespace ConFin.View
{
    partial class FormPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoa));
            this.dataGridViewMostra = new System.Windows.Forms.DataGridView();
            this.buttonNova = new System.Windows.Forms.Button();
            this.buttonAltera = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.pessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostra
            // 
            this.dataGridViewMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessoaId,
            this.nome,
            this.cpfcnpj,
            this.endereco,
            this.bairro,
            this.telefone,
            this.email});
            this.dataGridViewMostra.Location = new System.Drawing.Point(29, 62);
            this.dataGridViewMostra.Name = "dataGridViewMostra";
            this.dataGridViewMostra.RowHeadersWidth = 51;
            this.dataGridViewMostra.RowTemplate.Height = 24;
            this.dataGridViewMostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostra.Size = new System.Drawing.Size(772, 293);
            this.dataGridViewMostra.TabIndex = 0;
            // 
            // buttonNova
            // 
            this.buttonNova.Location = new System.Drawing.Point(128, 411);
            this.buttonNova.Name = "buttonNova";
            this.buttonNova.Size = new System.Drawing.Size(110, 23);
            this.buttonNova.TabIndex = 1;
            this.buttonNova.Text = "Nova Pessoa";
            this.buttonNova.UseVisualStyleBackColor = true;
            // 
            // buttonAltera
            // 
            this.buttonAltera.Location = new System.Drawing.Point(321, 411);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(110, 23);
            this.buttonAltera.TabIndex = 2;
            this.buttonAltera.Text = "Alterar Pessoa";
            this.buttonAltera.UseVisualStyleBackColor = true;
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(512, 411);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(110, 23);
            this.buttonExclui.TabIndex = 3;
            this.buttonExclui.Text = "Excluir Pessoa";
            this.buttonExclui.UseVisualStyleBackColor = true;
            // 
            // pessoaId
            // 
            this.pessoaId.DataPropertyName = "pessoaId";
            this.pessoaId.HeaderText = "Id";
            this.pessoaId.MinimumWidth = 6;
            this.pessoaId.Name = "pessoaId";
            this.pessoaId.Width = 60;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.DataPropertyName = "cpfcnpj";
            this.cpfcnpj.HeaderText = "CPF/CNPJ";
            this.cpfcnpj.MinimumWidth = 6;
            this.cpfcnpj.Name = "cpfcnpj";
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.Width = 200;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 6;
            this.bairro.Name = "bairro";
            this.bairro.Width = 200;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 486);
            this.Controls.Add(this.buttonExclui);
            this.Controls.Add(this.buttonAltera);
            this.Controls.Add(this.buttonNova);
            this.Controls.Add(this.dataGridViewMostra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostra;
        private System.Windows.Forms.Button buttonNova;
        private System.Windows.Forms.Button buttonAltera;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}