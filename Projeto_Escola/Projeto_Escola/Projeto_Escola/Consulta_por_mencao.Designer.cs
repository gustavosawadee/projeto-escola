namespace Projeto_Escola
{
    partial class frmConsultaPorMencao
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
            this.datGridDisciplinas = new System.Windows.Forms.DataGridView();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // datGridDisciplinas
            // 
            this.datGridDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDisciplinas.Location = new System.Drawing.Point(13, 115);
            this.datGridDisciplinas.Name = "datGridDisciplinas";
            this.datGridDisciplinas.Size = new System.Drawing.Size(531, 150);
            this.datGridDisciplinas.TabIndex = 21;
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(224, 40);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Menção:";
            // 
            // frmConsultaPorMencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.datGridDisciplinas);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaPorMencao";
            this.Text = "Consulta por Menção";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaPorMencao_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datGridDisciplinas;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label label1;
    }
}