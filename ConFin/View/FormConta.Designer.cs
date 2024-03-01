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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostra
            // 
            this.dataGridViewMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
    }
}