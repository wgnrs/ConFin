namespace ConFin.View
{
    partial class FormCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCidade));
            this.dataGridViewMostra = new System.Windows.Forms.DataGridView();
            this.cidadeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNova = new System.Windows.Forms.Button();
            this.buttonAltera = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostra
            // 
            this.dataGridViewMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidadeId,
            this.nome,
            this.estadoSigla});
            this.dataGridViewMostra.Location = new System.Drawing.Point(41, 42);
            this.dataGridViewMostra.Name = "dataGridViewMostra";
            this.dataGridViewMostra.RowHeadersWidth = 51;
            this.dataGridViewMostra.RowTemplate.Height = 24;
            this.dataGridViewMostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostra.Size = new System.Drawing.Size(704, 300);
            this.dataGridViewMostra.TabIndex = 0;
            // 
            // cidadeId
            // 
            this.cidadeId.DataPropertyName = "cidadeId";
            this.cidadeId.HeaderText = "Id";
            this.cidadeId.MinimumWidth = 6;
            this.cidadeId.Name = "cidadeId";
            this.cidadeId.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // estadoSigla
            // 
            this.estadoSigla.DataPropertyName = "estadoSigla";
            this.estadoSigla.HeaderText = "Estado";
            this.estadoSigla.MinimumWidth = 6;
            this.estadoSigla.Name = "estadoSigla";
            this.estadoSigla.Width = 80;
            // 
            // buttonNova
            // 
            this.buttonNova.Location = new System.Drawing.Point(182, 387);
            this.buttonNova.Name = "buttonNova";
            this.buttonNova.Size = new System.Drawing.Size(105, 23);
            this.buttonNova.TabIndex = 1;
            this.buttonNova.Text = "Nova cidade";
            this.buttonNova.UseVisualStyleBackColor = true;
            this.buttonNova.Click += new System.EventHandler(this.buttonNova_Click);
            // 
            // buttonAltera
            // 
            this.buttonAltera.Location = new System.Drawing.Point(309, 387);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(105, 23);
            this.buttonAltera.TabIndex = 2;
            this.buttonAltera.Text = "Alterar cidade";
            this.buttonAltera.UseVisualStyleBackColor = true;
            this.buttonAltera.Click += new System.EventHandler(this.buttonAltera_Click);
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(439, 387);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(105, 23);
            this.buttonExclui.TabIndex = 3;
            this.buttonExclui.Text = "Excluir cidade";
            this.buttonExclui.UseVisualStyleBackColor = true;
            // 
            // FormCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 461);
            this.Controls.Add(this.buttonExclui);
            this.Controls.Add(this.buttonAltera);
            this.Controls.Add(this.buttonNova);
            this.Controls.Add(this.dataGridViewMostra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostra;
        private System.Windows.Forms.Button buttonNova;
        private System.Windows.Forms.Button buttonAltera;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSigla;
    }
}