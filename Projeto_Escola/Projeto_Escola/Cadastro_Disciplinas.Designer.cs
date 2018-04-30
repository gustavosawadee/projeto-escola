namespace Projeto_Escola
{
    partial class frmCadDisciplinas
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
            this.lblCadCodigo = new System.Windows.Forms.Label();
            this.lblCadDesc = new System.Windows.Forms.Label();
            this.lblCadSigla = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCadDesc = new System.Windows.Forms.TextBox();
            this.txbCadSigla = new System.Windows.Forms.TextBox();
            this.gpbNav = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridViewDisciplinas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.gpbNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadCodigo
            // 
            this.lblCadCodigo.AutoSize = true;
            this.lblCadCodigo.Location = new System.Drawing.Point(37, 37);
            this.lblCadCodigo.Name = "lblCadCodigo";
            this.lblCadCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCadCodigo.TabIndex = 0;
            this.lblCadCodigo.Text = "Código:";
            // 
            // lblCadDesc
            // 
            this.lblCadDesc.AutoSize = true;
            this.lblCadDesc.Location = new System.Drawing.Point(37, 65);
            this.lblCadDesc.Name = "lblCadDesc";
            this.lblCadDesc.Size = new System.Drawing.Size(58, 13);
            this.lblCadDesc.TabIndex = 1;
            this.lblCadDesc.Text = "Descrição:";
            // 
            // lblCadSigla
            // 
            this.lblCadSigla.AutoSize = true;
            this.lblCadSigla.Location = new System.Drawing.Point(37, 97);
            this.lblCadSigla.Name = "lblCadSigla";
            this.lblCadSigla.Size = new System.Drawing.Size(33, 13);
            this.lblCadSigla.TabIndex = 2;
            this.lblCadSigla.Text = "Sigla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite a Sigla da disciplina a ser pesquisada:";
            // 
            // txbCadDesc
            // 
            this.txbCadDesc.Location = new System.Drawing.Point(101, 62);
            this.txbCadDesc.Name = "txbCadDesc";
            this.txbCadDesc.Size = new System.Drawing.Size(100, 20);
            this.txbCadDesc.TabIndex = 5;
            // 
            // txbCadSigla
            // 
            this.txbCadSigla.Location = new System.Drawing.Point(101, 94);
            this.txbCadSigla.Name = "txbCadSigla";
            this.txbCadSigla.Size = new System.Drawing.Size(100, 20);
            this.txbCadSigla.TabIndex = 6;
            // 
            // gpbNav
            // 
            this.gpbNav.Controls.Add(this.btnUltimo);
            this.gpbNav.Controls.Add(this.btnAnterior);
            this.gpbNav.Controls.Add(this.btnProximo);
            this.gpbNav.Controls.Add(this.btnPrimeiro);
            this.gpbNav.Location = new System.Drawing.Point(40, 146);
            this.gpbNav.Name = "gpbNav";
            this.gpbNav.Size = new System.Drawing.Size(337, 68);
            this.gpbNav.TabIndex = 7;
            this.gpbNav.TabStop = false;
            this.gpbNav.Text = "Navegação";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(248, 32);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 6;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(167, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(86, 32);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(6, 32);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 0;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Novo Registro";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(453, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(507, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(507, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Excluir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(507, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Incluir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridViewDisciplinas
            // 
            this.dataGridViewDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinas.Location = new System.Drawing.Point(40, 220);
            this.dataGridViewDisciplinas.Name = "dataGridViewDisciplinas";
            this.dataGridViewDisciplinas.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewDisciplinas.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 13;
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(101, 34);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 14;
            // 
            // frmCadDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 467);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewDisciplinas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.gpbNav);
            this.Controls.Add(this.txbCadSigla);
            this.Controls.Add(this.txbCadDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCadSigla);
            this.Controls.Add(this.lblCadDesc);
            this.Controls.Add(this.lblCadCodigo);
            this.Name = "frmCadDisciplinas";
            this.Text = "Cadastro Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadDisciplinas_FormClosing);
            this.Load += new System.EventHandler(this.frmCadDisciplinas_Load);
            this.gpbNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadCodigo;
        private System.Windows.Forms.Label lblCadDesc;
        private System.Windows.Forms.Label lblCadSigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCadDesc;
        private System.Windows.Forms.TextBox txbCadSigla;
        private System.Windows.Forms.GroupBox gpbNav;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridViewDisciplinas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbCod;
    }
}