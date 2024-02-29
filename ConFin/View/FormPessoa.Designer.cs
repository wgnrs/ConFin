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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostra
            // 
            this.dataGridViewMostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostra.Location = new System.Drawing.Point(49, 64);
            this.dataGridViewMostra.Name = "dataGridViewMostra";
            this.dataGridViewMostra.RowHeadersWidth = 51;
            this.dataGridViewMostra.RowTemplate.Height = 24;
            this.dataGridViewMostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostra.Size = new System.Drawing.Size(663, 293);
            this.dataGridViewMostra.TabIndex = 0;
            // 
            // buttonNova
            // 
            this.buttonNova.Location = new System.Drawing.Point(107, 410);
            this.buttonNova.Name = "buttonNova";
            this.buttonNova.Size = new System.Drawing.Size(110, 23);
            this.buttonNova.TabIndex = 1;
            this.buttonNova.Text = "Nova Pessoa";
            this.buttonNova.UseVisualStyleBackColor = true;
            // 
            // buttonAltera
            // 
            this.buttonAltera.Location = new System.Drawing.Point(300, 410);
            this.buttonAltera.Name = "buttonAltera";
            this.buttonAltera.Size = new System.Drawing.Size(110, 23);
            this.buttonAltera.TabIndex = 2;
            this.buttonAltera.Text = "Alterar Pessoa";
            this.buttonAltera.UseVisualStyleBackColor = true;
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(491, 410);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(110, 23);
            this.buttonExclui.TabIndex = 3;
            this.buttonExclui.Text = "Excluir Pessoa";
            this.buttonExclui.UseVisualStyleBackColor = true;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 486);
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
    }
}