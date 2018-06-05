namespace ProjetoEscola
{
    partial class frmConsultaCadastroDeDisciplinas
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
            this.cbxCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnQuanSelecionados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o campo a ser pesquisado";
            // 
            // cbxCampoPesquisa
            // 
            this.cbxCampoPesquisa.FormattingEnabled = true;
            this.cbxCampoPesquisa.Items.AddRange(new object[] {
            "Código Disciplina",
            "Descrição",
            "Sigla"});
            this.cbxCampoPesquisa.Location = new System.Drawing.Point(251, 38);
            this.cbxCampoPesquisa.Name = "cbxCampoPesquisa";
            this.cbxCampoPesquisa.Size = new System.Drawing.Size(143, 21);
            this.cbxCampoPesquisa.TabIndex = 1;
            this.cbxCampoPesquisa.Text = "Escolha...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 192);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(52, 325);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(52, 372);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnQuanSelecionados
            // 
            this.btnQuanSelecionados.Location = new System.Drawing.Point(578, 325);
            this.btnQuanSelecionados.Name = "btnQuanSelecionados";
            this.btnQuanSelecionados.Size = new System.Drawing.Size(117, 63);
            this.btnQuanSelecionados.TabIndex = 6;
            this.btnQuanSelecionados.Text = "Quantidade de Selecionados";
            this.btnQuanSelecionados.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCadastroDeDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.btnQuanSelecionados);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxCampoPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaCadastroDeDisciplinas";
            this.Text = " Consulta Cadastral de Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCampoPesquisa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnQuanSelecionados;
    }
}