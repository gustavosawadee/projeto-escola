namespace Projeto_Escola
{
    partial class frmCadAlunos
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
            this.dataGridViewDisciplinas = new System.Windows.Forms.DataGridView();
            this.btnNovoR = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gpbNav = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCodDisciplina = new System.Windows.Forms.Label();
            this.lblCadSigla = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.lblCadMatricula = new System.Windows.Forms.Label();
            this.maskNasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).BeginInit();
            this.gpbNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDisciplinas
            // 
            this.dataGridViewDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinas.Location = new System.Drawing.Point(29, 386);
            this.dataGridViewDisciplinas.Name = "dataGridViewDisciplinas";
            this.dataGridViewDisciplinas.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewDisciplinas.TabIndex = 27;
            // 
            // btnNovoR
            // 
            this.btnNovoR.Location = new System.Drawing.Point(535, 148);
            this.btnNovoR.Name = "btnNovoR";
            this.btnNovoR.Size = new System.Drawing.Size(98, 23);
            this.btnNovoR.TabIndex = 22;
            this.btnNovoR.Text = "Novo Registro";
            this.btnNovoR.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(433, 148);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(487, 105);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(487, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(487, 40);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gpbNav
            // 
            this.gpbNav.Controls.Add(this.btnUltimo);
            this.gpbNav.Controls.Add(this.btnAnterior);
            this.gpbNav.Controls.Add(this.btnProximo);
            this.gpbNav.Controls.Add(this.btnPrimeiro);
            this.gpbNav.Location = new System.Drawing.Point(29, 298);
            this.gpbNav.Name = "gpbNav";
            this.gpbNav.Size = new System.Drawing.Size(337, 68);
            this.gpbNav.TabIndex = 21;
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
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(88, 51);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 19;
            // 
            // lblCodDisciplina
            // 
            this.lblCodDisciplina.AutoSize = true;
            this.lblCodDisciplina.Location = new System.Drawing.Point(85, 26);
            this.lblCodDisciplina.Name = "lblCodDisciplina";
            this.lblCodDisciplina.Size = new System.Drawing.Size(13, 13);
            this.lblCodDisciplina.TabIndex = 18;
            this.lblCodDisciplina.Text = "1";
            // 
            // lblCadSigla
            // 
            this.lblCadSigla.AutoSize = true;
            this.lblCadSigla.Location = new System.Drawing.Point(26, 83);
            this.lblCadSigla.Name = "lblCadSigla";
            this.lblCadSigla.Size = new System.Drawing.Size(35, 13);
            this.lblCadSigla.TabIndex = 16;
            this.lblCadSigla.Text = "Nasc:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.Location = new System.Drawing.Point(26, 54);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(38, 13);
            this.lblCadNome.TabIndex = 15;
            this.lblCadNome.Text = "Nome:";
            // 
            // lblCadMatricula
            // 
            this.lblCadMatricula.AutoSize = true;
            this.lblCadMatricula.Location = new System.Drawing.Point(26, 26);
            this.lblCadMatricula.Name = "lblCadMatricula";
            this.lblCadMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblCadMatricula.TabIndex = 14;
            this.lblCadMatricula.Text = "Matricula:";
            // 
            // maskNasc
            // 
            this.maskNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maskNasc.Location = new System.Drawing.Point(88, 77);
            this.maskNasc.Name = "maskNasc";
            this.maskNasc.Size = new System.Drawing.Size(100, 20);
            this.maskNasc.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "CEP:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(88, 106);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 36;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(88, 128);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 37;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(88, 151);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 38;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(88, 177);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 39;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(88, 205);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(100, 20);
            this.txbCep.TabIndex = 40;
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(88, 232);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(100, 20);
            this.txbRg.TabIndex = 41;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(88, 258);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 42;
            // 
            // frmCadAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 598);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskNasc);
            this.Controls.Add(this.dataGridViewDisciplinas);
            this.Controls.Add(this.btnNovoR);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gpbNav);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCodDisciplina);
            this.Controls.Add(this.lblCadSigla);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.lblCadMatricula);
            this.Name = "frmCadAlunos";
            this.Text = "Cadastro Alunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadAlunos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).EndInit();
            this.gpbNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisciplinas;
        private System.Windows.Forms.Button btnNovoR;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox gpbNav;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCodDisciplina;
        private System.Windows.Forms.Label lblCadSigla;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label lblCadMatricula;
        private System.Windows.Forms.DateTimePicker maskNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.TextBox txbTelefone;
    }
}