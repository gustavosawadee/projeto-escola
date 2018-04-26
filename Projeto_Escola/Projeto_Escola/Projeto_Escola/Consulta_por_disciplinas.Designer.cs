namespace Projeto_Escola
{
    partial class frmConsultaPorDisciplinas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblSigla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // datGridDisciplinas
            // 
            this.datGridDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDisciplinas.Location = new System.Drawing.Point(15, 135);
            this.datGridDisciplinas.Name = "datGridDisciplinas";
            this.datGridDisciplinas.Size = new System.Drawing.Size(531, 150);
            this.datGridDisciplinas.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sigla:";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(129, 45);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltro.TabIndex = 12;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(281, 48);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(28, 13);
            this.lblSigla.TabIndex = 15;
            this.lblSigla.Text = "DSII";
            // 
            // frmConsultaPorDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 328);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.datGridDisciplinas);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaPorDisciplinas";
            this.Text = "Consulta por Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaPorDisciplinas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datGridDisciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblSigla;
    }
}