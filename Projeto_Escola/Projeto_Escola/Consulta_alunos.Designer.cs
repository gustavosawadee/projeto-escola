namespace Projeto_Escola
{
    partial class frmConsultaAlunos
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
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnqtdSelecionados = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.datGridDisciplinas = new System.Windows.Forms.DataGridView();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(31, 368);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 13;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnqtdSelecionados
            // 
            this.btnqtdSelecionados.Location = new System.Drawing.Point(450, 313);
            this.btnqtdSelecionados.Name = "btnqtdSelecionados";
            this.btnqtdSelecionados.Size = new System.Drawing.Size(112, 58);
            this.btnqtdSelecionados.TabIndex = 12;
            this.btnqtdSelecionados.Text = "Quantidade De Selecionados";
            this.btnqtdSelecionados.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(31, 313);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // datGridDisciplinas
            // 
            this.datGridDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDisciplinas.Location = new System.Drawing.Point(31, 145);
            this.datGridDisciplinas.Name = "datGridDisciplinas";
            this.datGridDisciplinas.Size = new System.Drawing.Size(531, 150);
            this.datGridDisciplinas.TabIndex = 10;
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(349, 30);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(213, 20);
            this.txbFiltro.TabIndex = 9;
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(222, 30);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha o campo a ser pesquisado:";
            // 
            // frmConsultaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 413);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnqtdSelecionados);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.datGridDisciplinas);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaAlunos";
            this.Text = "Consulta de Alunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaAlunos_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnqtdSelecionados;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView datGridDisciplinas;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label label1;
    }
}