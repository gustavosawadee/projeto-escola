namespace Projeto_Escola
{
    partial class frmConsultaDisciplinas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnqtdSelecionados = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dataGridViewDisciplinas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o campo a ser pesquisado:";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Disciplinas",
            "Sigla"});
            this.cbxFiltro.Location = new System.Drawing.Point(218, 26);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 1;
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(345, 26);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(213, 20);
            this.txbFiltro.TabIndex = 2;
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(27, 309);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnqtdSelecionados
            // 
            this.btnqtdSelecionados.Location = new System.Drawing.Point(446, 309);
            this.btnqtdSelecionados.Name = "btnqtdSelecionados";
            this.btnqtdSelecionados.Size = new System.Drawing.Size(112, 58);
            this.btnqtdSelecionados.TabIndex = 5;
            this.btnqtdSelecionados.Text = "Quantidade De Selecionados";
            this.btnqtdSelecionados.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(27, 364);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDisciplinas
            // 
            this.dataGridViewDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinas.Location = new System.Drawing.Point(40, 90);
            this.dataGridViewDisciplinas.Name = "dataGridViewDisciplinas";
            this.dataGridViewDisciplinas.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewDisciplinas.TabIndex = 13;
            // 
            // frmConsultaDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.dataGridViewDisciplinas);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnqtdSelecionados);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaDisciplinas";
            this.Text = "Consulta de Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaDisciplinas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnqtdSelecionados;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dataGridViewDisciplinas;
    }
}