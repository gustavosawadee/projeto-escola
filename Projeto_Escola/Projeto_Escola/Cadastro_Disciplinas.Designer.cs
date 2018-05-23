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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterarCad = new System.Windows.Forms.Button();
            this.btnExcluirCad = new System.Windows.Forms.Button();
            this.btnIncluirDisciplina = new System.Windows.Forms.Button();
            this.dataGridViewDisciplinas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCadCodigo = new System.Windows.Forms.Label();
            this.lblCadCod = new System.Windows.Forms.Label();
            this.gpbNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).BeginInit();
            this.SuspendLayout();
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
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(167, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(86, 32);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(6, 32);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 0;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(507, 121);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarCad
            // 
            this.btnAlterarCad.Location = new System.Drawing.Point(507, 92);
            this.btnAlterarCad.Name = "btnAlterarCad";
            this.btnAlterarCad.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCad.TabIndex = 9;
            this.btnAlterarCad.Text = "Alterar";
            this.btnAlterarCad.UseVisualStyleBackColor = true;
            this.btnAlterarCad.Click += new System.EventHandler(this.btnAlterarCad_Click);
            // 
            // btnExcluirCad
            // 
            this.btnExcluirCad.Location = new System.Drawing.Point(507, 60);
            this.btnExcluirCad.Name = "btnExcluirCad";
            this.btnExcluirCad.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCad.TabIndex = 10;
            this.btnExcluirCad.Text = "Excluir";
            this.btnExcluirCad.UseVisualStyleBackColor = true;
            this.btnExcluirCad.Click += new System.EventHandler(this.btnExcluirCad_Click);
            // 
            // btnIncluirDisciplina
            // 
            this.btnIncluirDisciplina.Location = new System.Drawing.Point(507, 31);
            this.btnIncluirDisciplina.Name = "btnIncluirDisciplina";
            this.btnIncluirDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirDisciplina.TabIndex = 11;
            this.btnIncluirDisciplina.Text = "Incluir";
            this.btnIncluirDisciplina.UseVisualStyleBackColor = true;
            this.btnIncluirDisciplina.Click += new System.EventHandler(this.btnIncluirDisciplina_Click);
            // 
            // dataGridViewDisciplinas
            // 
            this.dataGridViewDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinas.Location = new System.Drawing.Point(40, 220);
            this.dataGridViewDisciplinas.Name = "dataGridViewDisciplinas";
            this.dataGridViewDisciplinas.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewDisciplinas.TabIndex = 12;
            this.dataGridViewDisciplinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisciplinas_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 13;
            // 
            // lblCadCodigo
            // 
            this.lblCadCodigo.AutoSize = true;
            this.lblCadCodigo.Location = new System.Drawing.Point(40, 31);
            this.lblCadCodigo.Name = "lblCadCodigo";
            this.lblCadCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCadCodigo.TabIndex = 14;
            this.lblCadCodigo.Text = "Código";
            // 
            // lblCadCod
            // 
            this.lblCadCod.AutoSize = true;
            this.lblCadCod.Location = new System.Drawing.Point(98, 31);
            this.lblCadCod.Name = "lblCadCod";
            this.lblCadCod.Size = new System.Drawing.Size(40, 13);
            this.lblCadCod.TabIndex = 15;
            this.lblCadCod.Text = "Código";
            // 
            // frmCadDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 473);
            this.Controls.Add(this.lblCadCod);
            this.Controls.Add(this.lblCadCodigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewDisciplinas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterarCad);
            this.Controls.Add(this.btnExcluirCad);
            this.Controls.Add(this.btnIncluirDisciplina);
            this.Controls.Add(this.gpbNav);
            this.Controls.Add(this.txbCadSigla);
            this.Controls.Add(this.txbCadDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCadSigla);
            this.Controls.Add(this.lblCadDesc);
            this.Name = "frmCadDisciplinas";
            this.Text = "Cadastro Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadDisciplinas_FormClosing);
            this.gpbNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterarCad;
        private System.Windows.Forms.Button btnExcluirCad;
        private System.Windows.Forms.Button btnIncluirDisciplina;
        private System.Windows.Forms.DataGridView dataGridViewDisciplinas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCadCodigo;
        private System.Windows.Forms.Label lblCadCod;
    }
}